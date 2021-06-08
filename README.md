# SOFTWARE DE GESTÃO DE ORDEM DE SERVIÇO
 Este é um software, de código aberto, que foi desenvolvido durante um estágio supervisionado. Este software tem como função ter um controle de equipamento interno. ]

# Informações detalhadas sobre o projeto ---> https://tinyurl.com/detalhesOS
 

### Importante ###
 Este programa foi projetado para funcionar em uma rede especifica. Caso você tenha interesse de testa-ló é necessário que você realize alguns ajustes no código fonte.
 
# Ajustes:
|
|___ 1 --> Em "db/Banco.cs" devemos direcioanr um caminho válido para o arquivo do banco de dados.
|    |
|    |__ Situação 1 : Arquivo do banco está em uma pasta na rede ---> 
|    |   passo 1: na linha 16 devemos informar o ip da maquina, como no exemplo abaixo.
|    |   exemplo -> string ip = "X.X.X.X";
|    |
|    |   passo 2: na linha 18 informe o caminho válido na rede, como no exemplo abaixo.
|    |   exemplo -> conexao = new SQLiteConnection(@"Data Source=\\" + ip + @"CaminhoDoSeuArquivoNaRede\banco.sqlite3", true);
|    |
|    |   passo 3: Aponte novamente o arquivo na linha 22.
|    |   exemplo -> string caminho = @"\\"+ ip + @"\CaminhoDoSeuArquivo";
|    |
|    |__ Situação 2 : Arquivo do banco está em uma pasta local ---> Apague a linha 16.
|    |   passo 1: apague a linha 16.
|    |
|    |   passo 2: na linha 18 informe o caminho válido local, como no exemplo abaixo.
|    |   exemplo -> conexao = new SQLiteConnection("Data Source="/CaminhoDoSeuArquivoLocal\banco.sqlite3");
|    |
|    |   passo 3: Aponte novamente o arquivo na linha 22.
|    |   exemplo -> string caminho = @"\\CaminhoDoSeuArquivoLocal\banco.sqlite3";
|
|
|__ 2 --> Mova o arquivo banco.sqlite3 dentro de bkp-banco para o caminho válido acima. 
    
