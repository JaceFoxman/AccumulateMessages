
Imports System
Imports System.Net.Security

Module MessageProgram
    Sub Main(args As String())
        'uncomment to test interactively
        'Test.Manual()
        Test.Auto()
    End Sub



    'Use this function to write what Test program needs, example: when test program gives clear true/false run through if statement
    Function UserMessages(ByVal newMessage As String, ByVal clear As Boolean) As String

        'brings test data as array from Test program, this allows the exact string needed to be written in the code to appear. 
        Static messages As New Text.StringBuilder()

        If  Then

        End If

        Return messages
    End Function


End Module
