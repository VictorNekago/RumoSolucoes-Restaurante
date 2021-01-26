# RumoSolucoes-Restaurante
 Trabalho Restaurante Rumo Soluçoes De Victor Sousa

1-Baixe o projeto
2-Crie uma base no sql server com o nome RumoRestaurante.Desenv
3- Insira o data source do seu sql server no arquivo do web config do projeto 
exemplo: 
<connectionStrings>
		<add name="ConexaoPrincipal" connectionString="Data Source=(INSIRA SEU DATA SOURCE AQUI);Initial Catalog=RestauranteRumo.Desenv;Integrated Security=True;" providerName="System.Data.SqlClient" />	
	</connectionStrings>
 
 4-abra o package manager console e rode o seguinte comando : Uptade-Database -Verbose -Force
 
 5-Rode o projeto
