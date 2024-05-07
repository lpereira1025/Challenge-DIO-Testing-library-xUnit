<h1>Sistema de Vendas</h1>

<p>Este projeto é um exemplo simples de um sistema de vendas em C#. Ele inclui classes para calcular a média mensal de vendas e calcular o frete com base na distância.</p>

<h2>Funcionalidades</h2>

<ul>
    <li>Calcula a média mensal de vendas.</li>
    <li>Calcula o frete com base na distância em quilômetros.</li>
</ul>

<h2>Como usar</h2>

<h3>Calculando a média mensal de vendas</h3>

<pre><code>
var monthlyAverageValue = new BusinessSales(new SalesRepository()).CalculateMonthlyAverage(04, 2021);

Console.WriteLine($"Average Sales Value for the Month: {monthlyAverageValue}");
</code></pre>

<h3>Calculando o frete</h3>

<pre><code>
var valueFreight = new BusinessFreight().CalculateShipping(distanceKm);
</code></pre>

<h2>Testes Unitários</h2>

<p>O projeto inclui testes unitários para as funcionalidades de calcular a média mensal de vendas e calcular o frete. Os testes são baseados na estrutura xUnit e Mocking com Moq.</p>

<h3>Exemplos de Testes</h3>

<p>Aqui estão alguns exemplos de testes unitários incluídos no projeto:</p>

<h4>Teste de cálculo de frete para até 5km</h4>

<pre><code>
[Theory(DisplayName = "Deve calcular o frete com sucesso para até 5km")]
[InlineData(1)]
[InlineData(2)]
[InlineData(3)]
[InlineData(4)]
[InlineData(5)]
public void DeveCalcularFretePara5KmComSucesso(int distanciaKm)
{
    var valorFrete = new BusinessFreight().CalcularFrete(distanciaKm);

    Assert.Equal(0.00m, valorFrete);
}
</code></pre>

<h4>Teste de cálculo de frete entre 5km e 15km</h4>

<pre><code>
[Theory(DisplayName = "Deve calcular o frete com sucesso para uma distância maior que 5km e menor que 15km")]
[InlineData(6)]
[InlineData(7)]
[InlineData(8)]
[InlineData(9)]
[InlineData(10)]
[InlineData(11)]
[InlineData(12)]
[InlineData(13)]
[InlineData(14)]
public void DeveCalcularFreteEntre5KmE15KmComSucesso(int distanciaKm)
{
    var valorFrete = new BusinessFreight().CalcularFrete(distanciaKm);

    Assert.Equal(10.00m, valorFrete);
}
</code></pre>

<h4>Teste de cálculo de frete para mais de 15km</h4>

<pre><code>
[Theory(DisplayName = "Deve calcular o frete com sucesso para uma distância maior que 15km")]
[InlineData(16)]
[InlineData(20)]
[InlineData(50)]
[InlineData(400)]
public void DeveCalcularFreteAcimaDe15KmComSucesso(int distanciaKm)
{
    var valorFrete = new BusinessFreight().CalcularFrete(distanciaKm);

    Assert.Equal(30.00m, valorFrete);
}
</code></pre>
