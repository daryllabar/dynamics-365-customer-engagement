' <snippetretrievemultipleconditionoperatorsfetch9>


 fetchXml = "<fetch aggregate='true'>" &amp; ControlChars.CrLf &amp; _
     "                                    <entity name='salesorder'>" &amp; ControlChars.CrLf &amp; _
     "                                        <attribute name='totalamount' aggregate='sum' alias='total'/>" &amp; ControlChars.CrLf &amp; _
     "                                        <attribute name='datefulfilled' groupby='true' dategrouping='fiscal-period' alias='datefulfilled'/>" &amp; ControlChars.CrLf &amp; _
     "                                    </entity>" &amp; ControlChars.CrLf &amp; _
     "                                 </fetch>"

 ' Build fetch request and obtain results.
 efr = New RetrieveMultipleRequest() With {.Query = New FetchExpression(fetchXml)}
 entityResults = (CType(_service.Execute(efr), RetrieveMultipleResponse)).EntityCollection


 ' Display results.
 Console.WriteLine("List total of all orders grouped by period and year")
 Console.WriteLine("===================================================")
 For Each e In entityResults.Entities
     Console.WriteLine("Fetch Retrieved: {0}", e.FormattedValues("total"))
 Next e
 Console.WriteLine("<End of Listing>")
 Console.WriteLine()

' </snippetretrievemultipleconditionoperatorsfetch9>