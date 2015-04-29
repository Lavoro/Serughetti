Imports System
Imports System.Data
Imports System.Configuration
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls
Imports System.Collections.Generic
Imports System.Reflection
Imports System.ComponentModel

Namespace ASPItalia.Books.Web.Chapter20


    Public MustInherit Class EntityManager(Of T As New)


        Private Shared cache As New List(Of T)

        Public Function CreateNewEntity() As T
            Return New T()
        End Function

        Protected Overridable Function FindEntity(ByVal cache As List(Of T), ByVal entity As T) As T

        End Function

        Public Overridable Function ListAll() As List(Of T)
            ' Restituisco una copia
            Return New List(Of T)(cache)
        End Function

        Public Overridable Function ListAll(ByVal maximumRows As Integer, ByVal startRowIndex As Integer) As List(Of T)
            ' Se è uguale a zero o minore sono richieste le intere righe
            If maximumRows <= 0 Then Return Me.ListAll()

            Dim list As New List(Of T)(maximumRows)
            ' Restituisco una copia in base all'indice di partenza

            Dim i As Integer
            For i = startRowIndex To cache.Count And i < startRowIndex + maximumRows - 1
                list.Add(cache(i))
            Next

            list.TrimExcess()
            Return list
        End Function

        Public Overridable Function GetTotalEntities() As Integer
            Return cache.Count
        End Function

        Public Overridable Function GetSingle(ByVal entity As T) As T
            Return Me.FindEntity(cache, entity)
        End Function

        Public Function Add(ByVal entity As T) As T
            ' Controllo che non esista già
            If Not Me.FindEntity(cache, entity) Is Nothing Then
                Throw New ArgumentException("Entity already exists")
            End If

            cache.Add(entity)

            Return entity
        End Function

        Public Overridable Function Update(ByVal entity As T, ByVal old_entity As T) As T
            Dim original As T = Me.FindEntity(cache, entity)
            If original Is Nothing Then
                Throw New ArgumentException("Cannot find entity specified")
            End If

            ' Controllo la presenza di conflitti se richiesto
            If Not old_entity Is Nothing Then
                CheckConflict(old_entity, original)
            End If

            ' Sostituisco quella vecchia con quella nuova
            cache.Remove(original)
            cache.Add(entity)

            Return original
        End Function

        Private Sub CheckConflict(ByVal old_entity As T, ByVal original As T)
            ' Ottengo la lista delle proprietà
            Dim piList As PropertyDescriptorCollection = TypeDescriptor.GetProperties(GetType(T))
            Dim pd As PropertyDescriptor
            For Each pd In piList
                Dim v As Object = pd.GetValue(original)
                Dim v2 As Object = pd.GetValue(old_entity)
                ' Se il valore origiane non corrisponde a quello precedente
                ' nel frattempo è stato cambiato
                If v2 <> Nothing And v <> v2 And Not v.Equals(v2) Then
                    Throw New HttpException("The entity was changed during edit")
                End If
            Next
        End Sub

        Public Overridable Function Update(ByVal entity As T) As T
            Return Me.Update(entity, Nothing)
        End Function

        Public Overridable Sub Delete(ByVal entity As T)
            Dim original As T = Me.FindEntity(cache, entity)
            If original Is Nothing Then
                Throw New ArgumentException("Cannot find entity specified")
            End If

            cache.Remove(original)
        End Sub
    End Class
End Namespace