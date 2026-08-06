namespace eAgenda.Testes.Unidade.Modulos.ModuloContato;

[TestClass]
public sealed class ContatoTests
{
    [TestMethod]
    public void Validar_ComNomeVazio_DeveRetornarErro()
    {
        Contato contato = new Contato(string.Empty);

        List<string> erros = contato.Validar();

        Assert.HasCount(1, erros);
        Assert.AreEqual(
            "O campo \"Nome\" deve ser preenchido.",
            erros.First()
        );
    }

    [TestMethod]
    public void Validar_ComNomeCurto_DeveRetornarErro()
    {
        Contato contato = new Contato(new string('A', 1));

        List<string> erros = contato.Validar();

        Assert.HasCount(1, erros);
        Assert.AreEqual(
            "O campo \"Nome\" deve conter no mínimo 2 caracteres.",
            erros.First()
        );
    }

    [TestMethod]
    public void Validar_ComNomeLongo_DeveRetornarErro()
    {
        Contato contato = new Contato(new string('A', 101));

        List<string> erros = contato.Validar();

        Assert.HasCount(1, erros);
        Assert.AreEqual(
            "O campo \"Nome\" deve conter no máximo 100 caracteres.",
            erros.First()
        );
    }
}
