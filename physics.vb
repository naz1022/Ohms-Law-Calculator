Public Class Physics

    Public Function Volts(ByVal Current As Decimal, ByVal Resistance As Decimal) As Decimal

        Volts = Current * Resistance
    End Function
    Public Function Current(ByVal Volts As Decimal, ByVal Resistance As Decimal) As Decimal

        Const Zero As Decimal = 0.0

        If (Resistance <> Zero) And (Volts <> Zero) Then
            Current = Volts / Resistance
        Else
            Current = Zero
        End If
    End Function
    Public Function Resistance(ByVal Volts As Decimal, ByVal Current As Decimal) As Decimal

        Const Zero As Decimal = 0.0

        If (Volts <> Zero) And (Current <> Zero) Then
            Resistance = Volts / Current
        Else
            Resistance = Zero
        End If

    End Function

End Class
