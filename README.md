# 🚗 MarchPark 🅿

O **MarchPark** é um sistema de gerenciamento de estacionamentos desenvolvido com foco em eficiência e simplicidade. Este projeto foi criado para atender às necessidades operacionais e administrativas de estacionamentos, fornecendo ferramentas robustas para cadastro, controle e análise de dados relacionados ao fluxo de veículos e clientes.

## Funcionalidades Principais

1. **Cadastro de Veículos e Clientes**
   - Registro completo de veículos, incluindo placas no formato antigo e Mercosul.
   - Cadastro detalhado de clientes, com validação de dados como CPF e e-mail.

2. **Controle de Entrada e Saída de Veículos**
   - Registro automatizado de horários de entrada e saída.
   - Cálculo dinâmico do valor a pagar com base no tempo de permanência, considerando tarifas configuráveis.

3. **Relatórios (Histórico do Estacionamento)**
   - Geração de relatórios detalhados com filtros personalizáveis.
   - Exibição de dados históricos para análise de fluxo e faturamento.

4. **Gerenciamento e Gestão de Usuários**
   - Controle de acesso baseado em permissões.
   - Cadastro de novos usuários e gerenciamento de credenciais.

## Tecnologias Utilizadas

- **C# com Windows Forms**
  - Interface gráfica intuitiva e amigável para os usuários finais.

- **SQL Server**
  - Banco de dados relacional para armazenamento seguro e eficiente de informações.
  - Utilização de procedimentos armazenados (procedures) para operações otimizadas e maior segurança.

- **LINQ**
  - Realização de consultas em dados de maneira clara e legível, integrando lógica de negócios com o acesso ao banco de dados.

- **Validações e Máscaras**
  - Implementação de validações para campos como CPF, e-mail e placas de veículos.
  - Máscaras de entrada configuradas para padronização de dados.

## Destaques do Desenvolvimento

- **SQL no Hardcode e Procedures**
  - Uso de SQL embutido e procedimentos armazenados para realizar operações complexas diretamente no banco de dados.

- **Cálculo Dinâmico de Tarifas**
  - Algoritmo de cálculo que considera diferentes tarifas para a primeira hora e demais períodos, aplicando regras claras para o faturamento.

- **Flexibilidade na Personalização**
  - Relatórios configuráveis e telas ajustadas para diferentes tamanhos e resoluções.

O MarchPark foi criado com a intenção de simplificar a gestão de estacionamentos, integrando tecnologia e usabilidade para proporcionar uma experiência completa e funcional.

## TO DO

- Em breve estarei implementando a funcionalidade de exportar os dados do relatório desejado direto para um excel automaticamente.


## Vídeo do projeto no Linkedin:

https://www.linkedin.com/feed/update/urn:li:activity:7279308413644267520/

