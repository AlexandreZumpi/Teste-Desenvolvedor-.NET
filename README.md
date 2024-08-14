# O video do teste esta em https://youtu.be/P1uVnr3C_UM


# Teste Desenvolvedor .NET

![Aiko](imagens/logocrm.png)

Neste teste serão avaliados seus conhecimentos e a metodologia aplicada no desenvolvimento de uma aplicação .NET.

## O Desafio

O desafio é criar um servidor que provê uma API com o objetivo de fornecer informações sobre Inscrições de candidatos de um vestibular

## Requisitos

Esses requisitos são obrigatórios e devem ser desenvolvidos para a entrega do teste

### CRUD

Implementar as operações de **criação (POST)**, **consulta (GET)** (Por Id e GetAll), **atualização (PUT)** e **exclusão (DELETE)** de todas as entidades do seguinte diagrama:

!['D](imagens/backend_diagrama.png)

### Métodos

Após implementar o CRUD para as entidades, implemente os seguintes métodos:

* `Inscrições por CPF`: Implementar um método que recebe um CPF como parâmetro e retorna TODAS inscrições vinculadas aquele CPF.

* `Inscrições por Oferta`: Recebe o identificador de uma oferta e retorna as inscrições associados aquela oferta.

## O que é permitido

* Linguagem C#

* .NET Framework ou .NET Core ou .NET 5

* PostgreSQL, MySQL, Oracle, etc

* Mapeamento objeto-relacional (ORM)

* Qualquer tecnologia complementar as citadas anteriormente são permitidas desde que seu uso seja justificável

## O que não é permitido

* Bancos de Dados **não relacionais**.
  
* Utilizar bibliotecas ou códigos de terceiros que implementem algum dos requisitos.

* Outras linguagens diferentes de C#

## Recomendações
* O teste é propositalmente simples para permitir que você demostre suas habilidades e conhecimentos sem escrever muito código, sendo assim é interessante utilizar design patters e padrões de arquitetura.
* **Linter**: Desenvolva o projeto utilizando algum padrão de formatação de código.

## Extras

Aqui são listados algumas sugestões para você que quer ir além do desafio inicial. Lembrando que você não precisa se limitar a essas sugestões, se tiver pensado em outra funcionalidade que considera relevante ao escopo da aplicação fique à vontade para implementá-la.

* `Inscrições por CPF`: Implementar um método que recebe um CPF como parâmetro e retorna TODAS inscrições vinculadas aquele CPF, juntamente com dados imporrtantes para identificar de qual processo seletivo cada uma pertence.

* **Documentação**: Gerar a documentação da API de forma automatizada, utilizando o `swagger` ou equivalentes

* **Containerização**: Realizar a conteinerização da aplicação utilizando Docker

* **Front-end da aplicação**: Se seu foco é ser fullstack, você pode explorar isso desenvolvendo um front-end para a aplicação, seja em tecnologia .NET (MVC, Razor, Blazor) ou javacript (VueJS, Angular, ReactJS, etc.)

## Entregas

Para realizar a entrega do teste você deve:

* Relizar o fork e clonar esse repositório para sua máquina
  
* Criar uma branch com o nome de `teste/[SEU NOME]`
  * `[SEU NOME]`: Seu nome
  * Exemplo: `teste/fulano-da-silva`;
  
* Faça um commit da sua branch com a implementação do teste
  
* Realize o pull request da sua branch nesse repositório

Além do pull request você deve **gravar um vídeo de no máximo 30 minutos** mostrando o que foi desenvolvido, falando sobre as decisões que foram tomadas, as tecnologias utilizadas, arquitetura e tudo que você achar relevante. A facecam é opcional, mas é um extra desejável. Esse vídeo deve ser postado no youtube (pode ser não listado) e seu link deve estar no `README.md` do projeto.
