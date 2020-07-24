# SelecaoSoftplayer.
Seleção de pessoa Desenvolvedora .Net Core

Web Api para calcular juros compostos.

As APIs foram documentadas com Swagger.
O projeto foi desenvolvido utilizando ASP NET Core 3.1 e esta estruturado da seguinte forma:

# API 1: NetCore.TaxaJuros.API
Enpoint único:

Responsável por retornar a taxa de juro.

Responde pelo path relativo "/taxaJuros"

Observação: A chamada ao método da API também pode ser realizada pela interface do Swagger que pode ser acessada usando o caminho relativo "/swagger".

# API 2: NetCore.CalculaJuros.API

Nesta API existem 2 endpoints:

- Calcula Juros: 
Responsável por realizar o cálculo dos juros compostos de acordo com a fórmula: Valor Final = Valor Inicial * (1 + juros) ^ Tempo
Os parâmetros necessários para realizar o cálculo são: Valor Inicial (decimal) e Tempo (inteiro) que representa a quantidade de meses.
Responde pelo path relativo "/calculajuros?valorinicial=100&meses=5" sendo necessário informar os 2 parâmetros: valorInicial (decimal) e meses (inteiro).

Exemplo: "/calculajuros?valorinicial=100&meses=5".

- Show me the code: 
Responsável por retornar a URL do Github onde esta o código do projeto.
Responde pelo path relativo "/showmethecode" e não é necessário informar parâmetro.

Observação: A chamada aos métodos da API também pode ser realizada pela interface do Swagger que pode ser acessada usando o caminho relativo "/swagger".
