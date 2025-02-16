
Imports System
Imports System.Net.Security

Module MessageProgram
    Sub Main(args As String())
        'uncomment to test interactively
        'Test.Manual()
        Test.Auto()
    End Sub


    'Jason Permann
    'Spring 2025
    'RCET2265
    'Accumulate Message
    'https://github.com/JaceFoxman/AccumulateMessages.git

    'Use this function to write what Test program needs, example: when test program gives clear true/false run through if statement
    Function UserMessages(ByVal newMessage As String, ByVal clear As Boolean) As String

        'brings test data as array from Test program, this allows the exact string needed to be written in the code to appear. 
        Static messages As New Text.StringBuilder()

        'if Test program gives clear = true then clear 
        If clear = True Then
            messages.Clear()

            'if new message is cleared then write single line of nothing. must be single line ot test will think there is more "nothing" than there is
        ElseIf newMessage = "" Then
            messages.Append(newMessage)

            'if Test asks for message or clear is false, then write array values for Lbound to Ubound. AppendLine allows carriage return without using vbnewline or console.writeline.
        ElseIf newMessage = newMessage Then
            messages.AppendLine(newMessage)

        End If

        'messages.ToString allows the return data value to match the function value established, which was string
        Return messages.ToString

    End Function


End Module
