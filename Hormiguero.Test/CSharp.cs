using Antlr4.Runtime;
using System;
using System.Text;
using Hormiguero.Models;
using System.Collections.Generic;

namespace Hormiguero.Test
{
    public class CSharp
    {
        public List<CSharpTokenValue> ProcessUsings(StringBuilder text)
        {
            var result = new List<CSharpTokenValue>();
            try
            {               
                ICharStream inputStream = new AntlrInputStream(text.ToString());
                CSharpLexer csharpLexer = new CSharpLexer(inputStream);

                CommonTokenStream commonTokenStream = new CommonTokenStream(csharpLexer);
                CSharpPreprocessorParser csharpParser = new CSharpPreprocessorParser(commonTokenStream);
                
                CSharpPreprocessorParser.Directive_new_line_or_sharpContext preprocessorContext = csharpParser.directive_new_line_or_sharp();
                
                CSharpPreprocessorParserVisitor visitor = new CSharpPreprocessorParserVisitor();
                visitor.Visit(preprocessorContext);

                result = visitor.csharpValues;
             
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex);
            }
            return result;
        }

    }
}
