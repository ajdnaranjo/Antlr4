using System;
using System.Collections.Generic;
using System.Text;
using Antlr4.Runtime;
using Hormiguero.Models;


namespace Hormiguero.App
{
    public class CSharp 
    {
       
        public void start() 
        {
            try
            {
                string input = "using someting";
                StringBuilder text = new StringBuilder();
                Console.WriteLine("Input the chat.");

                // to type the EOF character and end the input: use CTRL+D, then press <enter>
                while ((input = Console.ReadLine()) != "\u0004")
                {
                    text.AppendLine(input);
                }

               // AntlrInputStream inputStream = new AntlrInputStream(text.ToString());
                ICharStream inputStream = new AntlrInputStream(text.ToString());
                CSharpLexer csharpLexer = new CSharpLexer(inputStream);

                CommonTokenStream commonTokenStream = new CommonTokenStream(csharpLexer);
                CSharpPreprocessorParser csharpParser = new CSharpPreprocessorParser(commonTokenStream);               

                CSharpPreprocessorParser.Preprocessor_expressionContext preprocessorContext = csharpParser.preprocessor_expression();

                CSharpPreprocessorParserVisitor visitor = new CSharpPreprocessorParserVisitor();
                visitor.Visit(preprocessorContext);

                foreach (var value in visitor.csharpValues)
                {
                   Console.WriteLine("Token: {0} Value: {1}", value.Token, value.Value);
                }
                Console.Read();
            }

            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex);
            }
        }
    }
}


