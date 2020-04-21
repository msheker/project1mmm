Sub FillCells()
    For i = 1 To 2283
        If IsEmpty(Cells(i, 1)) = False Then
            last = Cells(i, 1)
        Else
            Cells(i, 1) = last
        End If
        
        If IsEmpty(Cells(i, 2)) = False Then
            lastB = Cells(i, 2)
        Else
            Cells(i, 2) = lastB
        End If
    Next i
End Sub
