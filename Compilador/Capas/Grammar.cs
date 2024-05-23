using Irony.Parsing;

namespace Compilador
{
    [Language("Simple", "1.0", "A simple grammar for demo purposes")]
    public class SimpleGrammar : Grammar
    {
        public SimpleGrammar()
        {
            var Identificador = new IdentifierTerminal("Identificador");
            var Numero = new NumberLiteral("Numero");
            var ifKeyword = ToTerm("if");
            var thenKeyword = ToTerm("then");
            var whileKeyword = ToTerm("while");
            var doKeyword = ToTerm("do");
            var returnKeyword = ToTerm("return");
            var assign = ToTerm("=");
            var plus = ToTerm("+");
            var minus = ToTerm("-");
            var mult = ToTerm("*");
            var div = ToTerm("/");

            var expr = new NonTerminal("expr");
            var stat = new NonTerminal("stat");
            var prog = new NonTerminal("prog");

            expr.Rule = expr + plus + expr
                      | expr + minus + expr
                      | expr + mult + expr
                      | expr + div + expr
                      | Numero
                      | Identificador;

            stat.Rule = ifKeyword + expr + thenKeyword + stat
                      | whileKeyword + expr + doKeyword + stat
                      | returnKeyword + expr
                      | Identificador + assign + expr
                      | expr;

            prog.Rule = MakePlusRule(prog, stat);

            this.Root = prog;

            RegisterOperators(1, "+", "-");
            RegisterOperators(2, "*", "/");
            MarkPunctuation("if", "then", "while", "do", "return", "=");

            RegisterBracePair("(", ")");
            RegisterBracePair("{", "}");
        }
    }
}
