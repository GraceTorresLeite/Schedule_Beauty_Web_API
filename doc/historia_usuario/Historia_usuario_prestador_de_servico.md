## **História 2: Prestador de serviço gerencia seus horários e recebe agendamentos de clientes**

**Como um(a)**  prestador de serviço,

**Quero** receber os agendamentos realizados por meus clientes sem que eu perca tempo na mediação do processo,

**Para** que eu não perca serviço por falta de retorno aos mesmos, assim como garantir um bom atendimento no momento da visita sem interrupções para intermediar novos agendamentos.

__


## CENÁRIOS

### **Cenário 1: Prestador de serviço recebe e-mail para confirmar agendamento**

**Dado que** o cliente enviou a solicitação de agendamento,

**Quando**   o prestador abrir o e-mail para confirmação,

**E**        analisar os dados do agendamento,

**Então**    o prestador de serviço terá dois botões com as opções de resposta (ACEITAR e RECUSAR).

__

### **Cenário 2: Prestador de serviço responde confirmação de agendamento com a opção "ACEITAR"**

**Dado que**  o prestador de serviço visualiza seu email com a notificação para confirmar o agendamento, assim como os dados do mesmo,

**Quando**   clicar no botão com a opção "ACEITAR",

**Então**    o prestador de serviço visualiza a confirmação de e-mail enviado (ao endereço de seu cliente reponsável pelo agendamento) padrão de seu serviço de caixa postal,

**E**       o horário na agenda altera de status de reservado (cor amarela) para ocupado (cor vermelha).

__

### **Cenário 3: Prestador de serviço responde confirmação de agendamento com a opção "RECUSAR"**

**Dado que**  o prestador de serviço visualiza seu email com a notificação para confirmar o agendamento, assim como os dados do mesmo

**Quando**   clicar no botão com a opção "Recusar" e informar o motivo da recusa,

**Então**    o prestador de serviço visualiza a confirmação de e-mail enviado (ao endereço de seu cliente reponsável pelo agendamento) padrão de seu serviço de caixa postal,

**E**       o horário na agenda altera de status de reservado (cor amarela) para disponível (cor branca).

__

### **Cenário 4: Prestador de serviço responde confirmação de agendamento mas precisa realizar ajustes antes de definir status"**

**Dado que** o prestador de serviço visualiza seu email com a notificação para confirmar o agendamento, assim como os dados do mesmo,

**Quando**   confere os dados,

**E**        percebe que precisa de ajustes ou mais informações,

**Então**    o profissional terá de recusar para que seu cliente possa realizar novo agendamento com os devidos ajustes.

__

### **Cenário 5: Mensagem de atualização de status "ACEITAR"**

**Dado que** o prestador de serviço responde a confirmação de agendamento

**Quando**   clicar em "ACEITAR"

**Então**    uma mesagem padrão será enviada ao seu cliente por e-mail.

__

### **Cenário 6: Mensagem de atualização de status "RECUSAR"**

**Dado que** o prestador de serviço responde a confirmação de agendamento

**Quando**   clicar em "RECUSAR"

**Então**   o prestador digitará o motivo da recusa que será enviada por e-mail juntamente com a mensagem padrão. 

__

### **Cenário 7: Agendamento realizado com opção de confirmação por "TELEFONE"**

**Dado que** o sistema envia a confirmação por padrão via e-mail

**Quando**  o prestador visualiza a opção de confirmação por "TELEFONE" 

**E**    clicar nas opções disponíveis de retorno (ACEITAR, RECUSAR),

**Então**  o prestador de serviço deverá executar essa tarefa manualmente.

___

### **Cenário 8: Agendamento realizado com opção de confirmação por "WHATSAPP"**

**Dado que** o sistema envia a confirmação por padrão via e-mail

**Quando**   o prestador visualiza a opção de confirmação por "WHATSAPP" 

**E**        clicar nas opções disponíveis de retorno (ACEITAR, RECUSAR),

**Então**    o prestador de serviço deverá executar essa tarefa manualmente.

__

### **Cenário 9: Agendamento sofre desistência**

**Dado que** a autonomia de excluir um agendamento é de competência do prestador do serviço,

**Quando**   de conhecimento da desistência de seu cliente,

**Então**    o prestador de serviço deverá consultar na lista de sua agenda do dia,

**E**        escolher o agendamento correspondente da desistência,

**Quando**   aleterar o status para disponível,

**Então**    o agendamento será excluído, enviando a confirmação de cancelamento para o cliente via e-mail.

**E**        e o horário na agenda atualizará seu status para disponível(cor branca).

__

### **Cenário 10: Prestador decide indisponibilizar horários de sua agenda com status "Disponível"**

**Dado que** o prestador de serviço determina seus horários de atendimento,

**Quando**   listado os horários da agenda,

**E**        o status for disponível,

**Então**    o prestador de serviço deverá clicar em status e alterar para indisponível.

__

### **Cenário 11: Prestador decide indisponibilizar horários de sua agenda com status "RESERVADO"**

**Dado que** o prestador de serviço determina seus horários de atendimento,

**Quando**   listado os horários da agenda,

**E**        o status for reservado,

**Então**    o prestador de serviço deverá responder a confirmação do agendamento optando pelo botão "RECUSAR",

**Quando**   o status liberar para disponível,

**Então**    o prestador de serviço deverá clicar em status e alterar para indisponível.

__

### **Cenário 12: Prestador decide indisponibilizar horários de sua agenda com status "OCUPADO"**

**Dado que** o prestador de serviço determina seus horários de atendimento,

**Quando**   listado os horários da agenda,

**E**        o status for ocupado, com a existência de um cliente,

**Então**    o prestador de serviço deverá alterar status para indisponível,

**Quando**   confirmado a ação na mensagem que aparecerá em tela,

**Então**    o status atualizará para indisponível e um e-mail de cancelamento será enviado ao cliente.

__
