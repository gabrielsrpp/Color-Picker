🎨 ColorPick - Simples Seletor de Cores

ColorPick é uma aplicação simples em C# para capturar a cor de qualquer ponto da tela e exibir seu valor em hexadecimal.


📌 Funcionalidades

Captura a cor do pixel sob o cursor enquanto o botão de captura está pressionado.
Exibe a cor capturada em um painel visual e seu código hexadecimal em um campo de texto.
Alterna o cursor para um "crosshair" durante a captura, melhorando a precisão.

🛠️ Como Funciona

Clique e segure o botão de captura para ativar a seleção de cor.
Mova o cursor sobre a cor desejada.
Solte o botão para finalizar a captura.
A cor e seu valor hexadecimal serão exibidos na interface.

🖥️ Tecnologias Utilizadas

C#
WinForms
Multithreading para captura contínua de cor

🚀 Como Executar

Clone este repositório:

bash:
git clone https://github.com/gabrielsrpp/ColorPick.git
Abra o projeto no Visual Studio.

Compile e execute o aplicativo.

📝 Código Principal

A funcionalidade principal do aplicativo é implementada através de:

Um loop em segundo plano que verifica continuamente a cor do pixel sob o cursor.
A função GetColorAt(Point location), que captura a cor exata de um ponto da tela.
O uso de eventos MouseDown e MouseUp para iniciar e parar a captura.

📷 Demonstração

![image](https://github.com/user-attachments/assets/36043921-c1fa-4850-81ac-831c9136e460)


📜 Licença

Este projeto é open-source.
