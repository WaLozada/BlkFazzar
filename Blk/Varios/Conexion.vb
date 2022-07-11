Module Conexion

    '----------Conexion Cifrada BLK -----------------------------------------------
    Public GL_ClaveEncrip = Mid$(GL_N, 11, 1) & Mid$(GL_N, 44, 1) & Mid$(GL_N, 38, 1) & Mid$(GL_N, 58, 1) & Mid$(GL_N, 53, 1) & Mid$(GL_N, 41, 1) & Mid$(GL_N, 3, 1) & Mid$(GL_N, 50, 1) & Mid$(GL_N, 53, 1) & Mid$(GL_N, 51, 1) & Mid$(GL_N, 65, 1)

    '--------- Acceso Server Azure -----------------------

    Public Servidor As String = "ô*é˜(Ô Üáê#&¡" & Chr(34) & "–²ÛÔç"
    Public BaseDatos As String = "Ãëêõóµùú"    ' Produccion
    Public User As String = "ö&Þ"
    Public Psw As String = "Â(¦Ý*¥ÝáÞ‹"

    '-----------------------------------------------------

    '---------VARIABLES BDCBLK-----------------
    Public ServerPub As String = "ô*é˜(Ô Üáê#&¡" & Chr(34) & "–²ÛÔç"
    Public BaseDatosPub As String = "Ãëäöûï"
    Public UserPub As String = "ö&Þ"
    Public ClPub As String = "Â(¦Ý*¥ÝáÞ‹"

    Public GL_Cpub = "Data Source='" & SeguridadBlk.UnEncryptStr(ServerPub, GL_ClaveEncrip) & "';Initial Catalog='" & SeguridadBlk.UnEncryptStr(BaseDatosPub, GL_ClaveEncrip) & "';User ID='" & SeguridadBlk.UnEncryptStr(UserPub, GL_ClaveEncrip) & "';Password='" & SeguridadBlk.UnEncryptStr(ClPub, GL_ClaveEncrip) & "'"
    Public ConnP As New SqlClient.SqlConnection(GL_Cpub)

    Public GL_CodPub As String
    Public GL_NitPub As String
    Public GL_Licencias As String
    Public GL_FechaVence As String
    Public GL_FechaHoy As String
    '---------------------------------------------

    Public CP As Boolean = Licenciamiento.ConexionPublica

    ''-------Server Local Bd Desarrollo -------------------

    'Public Servidor As String = "192.168.1.4"
    'Public BaseDatos As String = SeguridadBlk.UnEncryptStr("Ãëêõóµùú", GL_ClaveEncrip)
    'Public User As String = SeguridadBlk.UnEncryptStr("ô", GL_ClaveEncrip)
    'Public Psw As String = SeguridadBlk.UnEncryptStr("Â(¦Ý*¥ÝáÞ‹", GL_ClaveEncrip)
    '--------------------------------------------

    Public C0 = "Data Source='" & Servidor & "';Initial Catalog='" & BaseDatos & "';User ID='" & User & "';Password='" & Psw & "';encrypt=true;TrustServerCertificate=True;"

    Public Conn As New SqlClient.SqlConnection(C0)


End Module
