Imports System.IO
Imports System.Security.Cryptography
Imports System.Text


Module Algo
    Public Function MD5Checksum(ByVal FilePathe As String) As String
        Dim MD5Service As New System.Security.Cryptography.MD5CryptoServiceProvider
        Dim File() As Byte = IO.File.ReadAllBytes(FilePathe)
        Dim Bytes() As Byte = MD5Service.ComputeHash(File)
        Dim s As String
        For Each by As Byte In Bytes
            s += by.ToString("x2")
        Next
        Return s
    End Function
    Public Function MD5_txt(ByRef strText As String) As String
        Dim MD5Service As New System.Security.Cryptography.MD5CryptoServiceProvider
        Dim Bytes() As Byte = MD5Service.ComputeHash(System.Text.Encoding.ASCII.GetBytes(strText))
        Dim s As String
        For Each by As Byte In Bytes
            s += by.ToString("x2")
        Next
        Return s
    End Function
    Function hash_generator(ByVal hash_type As String, ByVal file_name As String)

        ' On déclare la variable : hash
        Dim hash
        If hash_type.ToLower = "md5" Then
            ' Initialise un objet de hash : md5
            hash = MD5.Create
        ElseIf hash_type.ToLower = "sha1" Then
            ' Initialise un objet de hash : SHA-1
            hash = SHA1.Create()
        ElseIf hash_type.ToLower = "sha256" Then
            ' Initialise un objet de hash : SHA-256
            hash = SHA256.Create()
        ElseIf hash_type.ToLower = "sha512" Then
            hash = SHA512.Create()
        ElseIf hash_type.ToLower = "sha384" Then
            hash = SHA384.Create()
        Else
            MsgBox("Type de hash inconnu : " & hash_type, MsgBoxStyle.Critical)
            Return "Error"
        End If

        ' On déclare une variable qui sera un tableau de bytes (octets)
        Dim hashValue() As Byte

        ' On crée un FileStream pour le fichier passé en paramètre

        Dim fileStream As FileStream = File.OpenRead(file_name)
        ' On positionne le curseur au début du stream
        fileStream.Position = 0
        ' On calcule le hash du fichier
        hashValue = hash.ComputeHash(fileStream)
        ' On convertit le tableau d'octets (bytes) en hexadécimal pour qu'on puisse le lire facilement
        Dim hash_hex = PrintByteArray(hashValue)

        ' On ferme le fichier ouvert
        fileStream.Close()

        ' On retourne le hash
        Return hash_hex

    End Function
    Public Function PrintByteArray(ByVal array() As Byte)

        Dim hex_value As String = ""

        ' On parcoure le tableau de bytes (octets)
        Dim i As Integer
        For i = 0 To array.Length - 1

            ' On convertit chaque octet (byte) en hexadécimal
            hex_value += array(i).ToString("X2")

        Next i

        ' On retourne la chaine de caractères en minuscules
        Return hex_value.ToLower

    End Function
    Public Function GetCRC32(ByVal sFileName As String) As String
        Try
            Dim FS As FileStream = New FileStream(sFileName, FileMode.Open, FileAccess.Read, FileShare.Read, 8192)
            Dim CRC32Result As Integer = &HFFFFFFFF
            Dim Buffer(4096) As Byte
            Dim ReadSize As Integer = 4096
            Dim Count As Integer = FS.Read(Buffer, 0, ReadSize)
            Dim CRC32Table(256) As Integer
            Dim DWPolynomial As Integer = &HEDB88320
            Dim DWCRC As Integer
            Dim i As Integer, j As Integer, n As Integer

            'Create CRC32 Table
            For i = 0 To 255
                DWCRC = i
                For j = 8 To 1 Step -1
                    If (DWCRC And 1) Then
                        DWCRC = ((DWCRC And &HFFFFFFFE) \ 2&) And &H7FFFFFFF
                        DWCRC = DWCRC Xor DWPolynomial
                    Else
                        DWCRC = ((DWCRC And &HFFFFFFFE) \ 2&) And &H7FFFFFFF
                    End If
                Next j
                CRC32Table(i) = DWCRC
            Next i

            'Calcualting CRC32 Hash
            Do While (Count > 0)
                For i = 0 To Count - 1
                    n = (CRC32Result And &HFF) Xor Buffer(i)
                    CRC32Result = ((CRC32Result And &HFFFFFF00) \ &H100) And &HFFFFFF
                    CRC32Result = CRC32Result Xor CRC32Table(n)
                Next i
                Count = FS.Read(Buffer, 0, ReadSize)
            Loop
            Return Hex(Not (CRC32Result))
        Catch ex As Exception
            Return ""
        End Try
    End Function
End Module