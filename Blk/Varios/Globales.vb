Module Globales

    Public Const GL_N = "1234567890ABCDEFGHIJKLMNÑOPQRSTUVWXYZabcdefghijklmnñopqrstuvwxyz*"
    Public Gl_NomCompañia As String = "Bulkmatic de Colombia S.A.S"
    Public Gl_Key As String
    Public Gl_ClaveOK As Integer
    Public SYS_GetPath As String
    Public GL_HDS As String

    '----------VARIABLES DE OPERACION -------
    Public Gl_DataSet As New DataSet
    Public Gl_Divipolitica As New Divipoliticas
    Public Gl_DivipolCargadas As Integer = 0 ' Bandera para conocer si las Divipoliticas estan Cargadas.(0-No, 1-Si)
    Public Gl_Cliente As New Clientes
    Public GL_Proveedor As New Proveedores
    Public GL_Empleado As New Empleados
    Public Gl_Producto As New Productos
    Public GL_ProductoCargados As Integer = 0
    Public GL_Editar As Integer = 0
    '----------------------------------------

    Public UsuarioApp As New Usuario()
    Public CompañiaApp As New Compañia()
    Public Ventanas As New Ventana()

    'Public Varentorno As String() = GetVariableEntorno()


End Module
