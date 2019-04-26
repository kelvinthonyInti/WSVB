Imports System
Imports System.Collections.Generic
Imports System.IO
Imports System.Net
Imports System.Text
Imports Newtonsoft.Json
Imports RestSharp

Module Program
    Private stb As New StringBuilder
    Sub Main(args As String())
        Console.WriteLine("Hello World!")
        Grabar_Producto()

    End Sub

    Sub Grabar_Producto()
        stb = New StringBuilder
        Dim item_product As String = ""
        stb.AppendLine("{'name':'hola', ")
        stb.AppendLine("'name_en':'hello', ")
        item_product = stb.ToString
        item_product = item_product.Replace("'", ChrW(34))
        Dim json As String = System.IO.File.ReadAllText("D:\IntiTec\CREDITEX\WS\product.txt", Encoding.Default)
        Dim client = New RestClient("http://5.189.151.80:8077/api/product.template_json")
        Dim request = New RestRequest(Method.POST)
        request.AddHeader("access_token", "access_token_cd8ac440abead2748aaf5e21fcd9e3591f9b8738")
        request.AddHeader("Content-Type", "application/json")
        request.AddParameter("undefined", json, ParameterType.RequestBody)
        Dim response As IRestResponse
        response = client.Execute(request)
        Dim escapedString As String = """c:\program files\my app\app.exe"""
        Console.WriteLine(item_product)
        Console.WriteLine(escapedString)
        Console.WriteLine(response.Content)
        Console.ReadLine()



        Exit Sub
    End Sub

End Module
