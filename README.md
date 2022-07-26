# GestaoDeProdutosAPI
API Para Gestão de Produtos - Teste.


Olá!

Essa é uma API para Cadastro de Produtos.
Feito em DDD, com uso de ORM e AutoMapper para Mapear os Objetos Automaticamente!

90% dos conceitos pedidos neste teste, eu não possuía conhecimento, então extraí as ideias de alguns lugares que citarei:  
https://www.youtube.com/watch?v=eUf5rhBGLAk (Wesley Willians explicando o conceito de DDD)  
https://www.youtube.com/watch?v=i9Il79a2uBU&t=7022s (Tutorial do Eduardo Pires para construir uma aplicação em DDD com o Entity Framwork)  
https://www.macoratti.net/19/08/aspnc_odata1.htm (José Carlos Macoratti explicando o Microsoft OData)  
https://www.learmoreseekmore.com/2021/07/intro-on-odata-v8-in-dotnet5-api.html (Instalando o OData AspNetCore no Projeto e Configurando)  
  
  
  
Na abstração dos requisitos, vi a necessidade de criar uma tabela específica para fornecedores. Já que no documento cita o campo de código, então abstraí 
fornecedores para uma tabela separada, ligada a produtos por uma chave estrangeira.  
  
Explicando as classes, temos:  
Produto:  
   ProdutoID         -- Inteiro, Incremental, Chave Primária  
   Descricao         -- String, Obrigatório  
   Situacao          -- String (Aceita os Valores {"Ativo", "Inativo"}. Também aceita o campo vazio, que é preenchido com o valor "Ativo")  
   DataFabruicacao   -- Data (Possui a Validação conjuntamente com o campo de Data de Validade)  
   DataValidade      -- Data (Possui a Validação conjuntamente com o campo de Data de Fabricação)  
   FornecedorID      -- Inteiro, Chave estrangeira do cadastro de Fornecedores, Obrigatório.  
  
Fornecedor:  
   FornecedorID    -- Inteiro, Incremental, Chave Primária  
   Descricao       -- String, Obrigatório  
   CNPJ            -- String  
  
  
Para utilizar os serviços, segue as instruções:  
  
Para o cadastro de Fornecedor:  
--Inclusão:  
{URL da Aplicação}/Fornecedor  
Método: POST  
JSON de Fornecedor com os campos no corpo da Requisição  
  
--Alteração:  
{URL da Aplicação}/Fornecedor  
Método: PUT  
JSON de Fornecedor com os campos no corpo da Requisição  
  
--Exclusão  
{URL da Aplicação}/Fornecedor/{ID do Fornecedor}  
Método: DELETE  
  
--Obter Lista com Todos os Fornecedores:  
{URL da Aplicação}/Fornecedor  
Método: GET  
Retorno de lista com os Fornecedores e os Produtos associados a cada um.  
  
--Obter Registro pelo ID  
{URL da Aplicação}/Fornecedor/{ID do Fornecedor}  
Método: GET  
Retorno do registro de Fornecedor e os Produtos associados a ele, caso tenha.  
  
  
Para o cadastro de Produtos:  
--Inclusão:  
{URL da Aplicação}/Produtos  
Método: POST  
JSON de Fornecedor com os campos no corpo da Requisição  
  
--Alteração:  
{URL da Aplicação}/Produtos  
Método: POST  
JSON de Fornecedor com os campos no corpo da Requisição. O campo ProdutoID deve ser preenchido com o ID em que se deseja alterar, para as alterações serem 
feitas na base.  
  
--Exclusão:  
{URL da Aplicação}/Produtos/{ID do Produto}  
Método: DELETE  
Altera o campo "Situação" para o valor "Inativo", como pede no Requisito.  
  
--Obter Lista com Parâmetros e Paginação:  
Para esta solicitação, utilizei o OData, que permite parâmetros dinâmicos na URL do serviço. Com ele, se consegue filtrar pelo campo que desejar, e paginar 
os resultados, pulando registros e selecionando a quantidade de exibição.  
Exemplo:  
{URL da Aplicação}/Produtos??$filter=Situacao eq 'Ativo'&$skip=30&$top=10  
Nessa consulta, está filtrando pelo campo de situação com o valor "Ativo", pulando os 30 primeiros registros e exibindo os 10 primeiros após o salto.  
Coloquei o OData na consulta, porque imaginei que é o que o requisito pede, é algo parecido como a consulta de um Mercado Livre, com os filtros e paginações dinâmicos.
Tem um método no repositório de Produtos, que faz a mesma coisa, porém diretamente no banco, mas não utilizei esse método, pois os parâmetros ficariam fixos na URL 
do serviço, e acredito não ser a intenção.  
{URL da Aplicação}/Produtos?$filter&$skip&$top (Sempre separando os parâmetros com o "&")  
Método: GET  
Retorno dos registros de Produtos com os dados do Fornecedor associado a cada produto.  
  
--Obter Registro pelo ID  
{URL da Aplicação}/Produtos/{ID do Produto}  
Método: GET  
Retorna o registro do Produto com os dados do Fornecedor associado.  
  
  
  
  
Essa foi a melhor forma que encontrei de extrair os dados do requisito e montar a API em .NET 5.  
Como são padrões que nunca utilizei, pode ser que algo não tenha ficado aos padrões atuais do mercado, mas me esforcei para encontrar uma melhor solução, 
principalmente técnica.  
  
  
  
Grato pela Oportunidade!

