
Public Structure Binary
    Public selectedSize As Double
    Public realSize As Double

    Public Shared Operator +(ByVal one As Binary, ByVal two As Binary) As Binary
        Return New Binary() With {
            .realSize = one.realSize + two.realSize,
            .selectedSize = one.selectedSize + two.selectedSize
            }
    End Operator

End Structure
