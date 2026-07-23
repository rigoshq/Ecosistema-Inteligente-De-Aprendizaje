namespace EIA.Core.Intelligence;

public class SelfReflectionEngine
{
    public IReadOnlyCollection<string> GetQuestions()
    {
        return
        [
            "¿Qué fue lo más interesante que descubriste?",

            "¿Qué concepto te pareció más difícil?",

            "¿Qué estrategia utilizaste para resolver el problema?",

            "¿Qué harías diferente la próxima vez?",

            "¿Qué tema te gustaría explorar ahora?"
        ];
    }
}