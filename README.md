# DIO | Digital Innovation One

### 🏗️ Desafio de projeto
🛠️ Desenvolvimento de um aplicativo console em C# simulando um sistema para estacionamento com as seguintes funções:  
* adicionar veículo - entrada  
* saída de veículo
* exibir o valor da permanência do veículo
* listar os veículos que estão no estacionamento

#### 🔸 Proposta
Desenvolver uma classe chamada "Estacionamento", conforme descrição abaixo:  

#### 🔸 Variáveis 
  * **precoInicial**: Tipo decimal. É o preço cobrado para deixar seu veículo estacionado.  
  * **precoPorHora**: Tipo decimal. É o preço por hora que o veículo permanecer estacionado.  
  * **veiculos**: É uma lista de string, representando uma coleção de veículos estacionados. Contém apenas a placa do veículo.  

#### 🔸 Métodos
  * **AdicionarVeiculo**: Método responsável por receber uma placa digitada pelo usuário e guardar na variável veiculos.  
  * **RemoverVeiculo**: Método responsável por verificar se um determinado veículo está estacionado, e caso positivo, irá pedir a quantidade de horas que ele permaneceu no estacionamento. Após isso, realiza o seguinte cálculo:  
  * **precoInicial**
  * **precoPorHora**: exibindo para o usuário.
  * **ListarVeiculos**: Lista todos os veículos presentes atualmente no estacionamento. Caso não haja nenhum, exibir a mensagem _"Não há veículos estacionados"_.

#### 🔸 Menu
Por último, deverá ser feito um menu interativo com as seguintes ações implementadas:
  1. Cadastrar veículo
  2. Remover veículo
  3. Listar veículos
  4. Encerrar

#### ⚠️ Observações
Este repositório é uma modificação do desafio original proposto ao final de um dos módulos do curso [Formação .NET Developer](https://www.dio.me/bootcamp/net-fundamentals?ref=aegea), disponível no repositório de [Leonardo Buta](https://github.com/leonardo-buta), instrutor do curso e que está disponível na plataforma de ensino [DIO](https://www.dio.me/).  
Preferi fazer deste modo ao invés de executar um _fork_, visto que o projeto original possui vários trechos do código já preenchido, e meu desejo é desenvolver o aplicativo do zero. Tentei contato com Leonardo para obter autorização de proceder desta forma (sem _fork_) mas ainda não obtive resposta.  
Assim que conseguir contato alterarei este README. 🙂

---

_Made with_ 😤 _by **Carlos Matheus**_
