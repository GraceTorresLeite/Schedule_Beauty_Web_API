## História de Usuário - _três aspectos críticos ( 3Cs)_

### **História 1: Cliente envia seu horário e serviço desejados ao seu prestador de serviço**

**Como um(a)**  cliente

**Quero** acesso rápido e fácil para o serviço no qual desejo contratar

**Para** garantir meu horário no momento que lembro da necessidade, de forma ágil e em tempo real, independente de um contato direto com o profissional

__


## CENÁRIOS

### **Cenário 1: Cliente com conexão na internet**

**Dado que** a agenda utiliza a navegação para executar a marcação em tempo real 

**Quando**   o cliente possui o serviço de dados ou wifi habilitado em seu dispositivo móvel ou desktop/notebook

**Então**    pelo navegador de sua preferência digitará a URL da Schedule Beauty 

**E**        após carregar a página terá acesso ao site com as abas de (HOME, SERVIÇOS E VALORES, AGENDE SEU HORÁRIO)

__

### **Cenário 2: Agendamento conectado na internet primeiro acesso do cliente**

**Dado que**  os atendimentos possuem flexibilidade de endereço, o mesmo será informado no momento de cada agendamento

**Quando**   o cliente navegar pelo site não haverá solicitação de cadastro para habilitar formulário de agendamento

**Então**    o cliente terá livre acesso a todas as páginas do site

__

### **Cenário 3: Agendamento desconectado da internet**

**Dado que** a agenda utiliza a navegação para executar a marcação em tempo real  

**Quando**   o cliente estiver com os serivços de dados ou wifi desabilitados ou indisponíveis

**Então**   mesmo que a página carregue devido a mémoria cache do navegador, o formulário de agedamento não completará o envio

**E**       uma tela retornará com a notificação padrão de seu navegador quanto a falta de conexão

__

### **Cenário 4: Cliente preenchendo formulário de agendamento com campos nulos**

**Dado que** Todos os campos do formulário contidos na aba "AGENDE SEU HORÁRIO" são obrigatórios. Exceto(Complemento,Mensagem)

**Quando**   um ou mais campos não forem informados,

**E**        clicar no botão "ENVIAR",

**Então**    o sistema apontará no campo expecífico uma caixa de diálogo com a seguinte mensagem "Preencha este campo.", e semelhantemente para cada campo subsequente.

__

### **Cenário 5: Cliente preenchendo formulário de agendamento com o campo e-mail inválido**

**Dado que** o cliente digita no formulário um e-mail sem o "@",

**Quando**   clicar no botão "ENVIAR",

**Então**    uma caixa de diálogo apontando para o devido campo surgirá informando:"Inclua um "@" no endereço de e-mail. "email_digitado.com" está com um "@" faltando. 

__

### **Cenário 6: Cliente preenchendo formulário de agendamento com o campo cep inválido**

**Dado que** o cliente digita números (faltantes, a mais que o esperado ou que não contenha na base de dados da API utilizada), 

**Quando**   clicar no botão "ENVIAR",

**Então**    um alerta será emitido pelo sistema com a seguinte mensagem "CEP não encontrado. + botão [OK]" para fechar a messagem.

__

### **Cenário 7: Agendamento enviado com sucesso**

**Dado que** cliente está com internet e com o endereço do site em seu navegador,

**Quando**   preenchido os dados como: Nome, Telefone, E-mail, Endereço, Serviço, Dia e Horário,

**E**        clicar no botão "Enviar",

**Então**    Uma mensagem aparecerá para que aguarde a confirmação do prestador de serviço e seu horário ficará temporariamente reservado(cor Amarela). 

__

### **Cenário 8: Agendamento confirmado**

**Dado que**  o cliente está aguardando confirmação (status amarelo),

**Quando**    receber a confirmação por e-mail,

**E**         for de aceitação,

**Então**     uma mesagem padrão será visualizada "Seu horário foi confirmado "data e horário", obrigado!" 

__

### **Cenário 9: Agendamento recusado**

**Dado que**  o cliente está aguardando confirmação (status amarelo),

**Quando**    receber a confirmação por e-mail,

**E**         for de recusa,

**Então**     uma mesagem padrão será visualizada "Seu horário foi recusado "data e horário". Motivo: "mensagem dada pelo prestador".

__


### **Cenário 10: Agendamento transição de status "BRANCO para AMARELO**

**Dado que** o horário está na cor branca indicando agendamento disponível,

**Quando**   o cliente indicar seus dados,serviço, data e horário

**E**        clicar no botão "Enviar",

**Então**    seu horário ficará temporariamente reservado, indicado pela cor amarela. 

__

### **Cenário 11 : Agendamento transição de status "AMARELO para VERMELHO**

**Dado que** o cliente está com horário na cor amarela indicando agendamento reservado,

**Quando**   o cliente receber a confirmação de aceite do prestador de serviço,

**Então**    seu horário ficará ocupado, indicado pela cor vermelha. 

__

### **Cenário 12 : Agendamento transição de status "VERMELHO para BRANCO" desistência**

**Dado que** o sistema não habilita edição após envio do agendamento por não exigir autenticação de cada usuário perfil cliente,

**E**        o cliente manifestar desistência de seu agendamento,

**Quando**   contatar diretamente seu prestador de serviço,

**Então**    o cliente receberá um e-mail com a confirmação de cancelamento. " Seu agendamento foi cancelado. Motivo: digitado pelo prestador de serviço",

**E**        o horário atualiza status para disponível (cor branca).

__
