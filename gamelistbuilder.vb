Imports System.IO
Imports System.Xml
Module gamelistbuilder
    Function Main(ByVal filename)
        Dim gamelist As New ArrayList
        Try
            Dim m_xmld As XmlDocument
            Dim m_nodelist As XmlNodeList
            Dim m_node As XmlNode
            m_xmld = New XmlDocument()
            m_xmld.Load(filename)
            m_nodelist = m_xmld.SelectNodes("/releases/release")
            For Each m_node In m_nodelist
                gamelist.Add(New game(m_node.ChildNodes.Item(1).InnerText, m_node.ChildNodes.Item(10).InnerText, m_node.ChildNodes.Item(3).InnerText))
            Next
        Catch errorVariable As Exception
            Console.Write(errorVariable.ToString())
        End Try
        Return gamelist
    End Function
End Module