Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Unidades de longitud
        cmbUnidadDesde.Items.AddRange(New String() {"metros", "kilómetros", "centímetros", "milímetros"})
        cmbUnidadA.Items.AddRange(New String() {"metros", "kilómetros", "centímetros", "milímetros"})

        ' Unidades de masa
        cmbUnidadDesde.Items.AddRange(New String() {"kilogramos", "gramos", "toneladas"})
        cmbUnidadA.Items.AddRange(New String() {"kilogramos", "gramos", "toneladas"})
    End Sub

    Private Sub btnConvertir_Click(sender As Object, e As EventArgs) Handles btnConvertir.Click
        Dim valor As Double
        Dim resultado As Double
        Dim unidadDesde As String = cmbUnidadDesde.SelectedItem
        Dim unidadA As String = cmbUnidadA.SelectedItem

        ' Verificar que se seleccionaron las unidades
        If String.IsNullOrEmpty(unidadDesde) Or String.IsNullOrEmpty(unidadA) Then
            lblResultado.Text = "Por favor, seleccione las unidades de conversión."
            Return
        End If

        ' Validar el valor ingresado
        If Not Double.TryParse(txtValor.Text, valor) Then
            lblResultado.Text = "Por favor, ingrese un valor numérico válido."
            Return
        End If

        ' Verificar si las unidades son de la misma categoría
        If (unidadDesde = "metros" Or unidadDesde = "kilómetros" Or unidadDesde = "centímetros" Or unidadDesde = "milímetros") AndAlso
       (unidadA = "metros" Or unidadA = "kilómetros" Or unidadA = "centímetros" Or unidadA = "milímetros") Then
            ' Lógica de conversión para longitud
            resultado = ConvertirLongitud(valor, unidadDesde, unidadA)
        ElseIf (unidadDesde = "kilogramos" Or unidadDesde = "gramos" Or unidadDesde = "toneladas") AndAlso
           (unidadA = "kilogramos" Or unidadA = "gramos" Or unidadA = "toneladas") Then
            ' Lógica de conversión para masa
            resultado = ConvertirMasa(valor, unidadDesde, unidadA)
        Else
            lblResultado.Text = "Las unidades seleccionadas no son compatibles."
            Return
        End If

        lblResultado.Text = $"Resultado: {resultado} {unidadA}"
    End Sub
    Private Function ConvertirLongitud(valor As Double, unidadDesde As String, unidadA As String) As Double
        ' Convertir a metros
        Select Case unidadDesde
            Case "kilómetros"
                valor *= 1000
            Case "centímetros"
                valor /= 100
            Case "milímetros"
                valor /= 1000
        End Select

        ' Convertir de metros a la unidad de destino
        Select Case unidadA
            Case "kilómetros"
                Return valor / 1000
            Case "centímetros"
                Return valor * 100
            Case "milímetros"
                Return valor * 1000
            Case Else
                Return valor ' En caso de que sea metros
        End Select
    End Function

    Private Function ConvertirMasa(valor As Double, unidadDesde As String, unidadA As String) As Double
        ' Convertir a kilogramos
        Select Case unidadDesde
            Case "gramos"
                valor /= 1000
            Case "toneladas"
                valor *= 1000
        End Select

        ' Convertir de kilogramos a la unidad de destino
        Select Case unidadA
            Case "gramos"
                Return valor * 1000
            Case "toneladas"
                Return valor / 1000
            Case Else
                Return valor ' En caso de que sea kilogramos
        End Select
    End Function

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
