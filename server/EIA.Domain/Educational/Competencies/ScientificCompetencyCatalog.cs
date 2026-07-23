namespace EIA.Domain.Educational.Competencies;

public static class ScientificCompetencyCatalog
{
    public static readonly ScientificCompetency Observation =
        new(
            "Observación",
            "Identifica fenómenos físicos utilizando los sentidos y herramientas de medición.");

    public static readonly ScientificCompetency Hypothesis =
        new(
            "Hipótesis",
            "Formula posibles explicaciones antes de experimentar.");

    public static readonly ScientificCompetency Experimentation =
        new(
            "Experimentación",
            "Diseña y ejecuta procedimientos experimentales.");

    public static readonly ScientificCompetency DataAnalysis =
        new(
            "Análisis de Datos",
            "Interpreta tablas, gráficas y resultados.");

    public static readonly ScientificCompetency MathematicalModel =
        new(
            "Modelación Matemática",
            "Representa fenómenos mediante ecuaciones.");

    public static readonly ScientificCompetency ScientificCommunication =
        new(
            "Comunicación Científica",
            "Explica resultados utilizando lenguaje científico.");
}