<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <title></title>
</head>
<body>
    <form id="rsvpform" runat="server">
        
        <div>
            <label>Модель машины:</label><input type="text" id="model" runat="server"/>
        </div>
        <div>
            <label>Марка машины:</label><input type="text" id="mark" runat="server"/>
        </div>
        <div>
            <label>Гос. номер:</label><input type="text" id="numbrg" runat="server"/>
        </div>

        <div>
            <label>Описание:</label><input type="text" id="info" runat="server"/>
        </div>
        <div>
            <label>ФИО владельца:</label><input type="text" id="name" runat="server"/>
        </div>
        <div>
            <label>Номер телефоа владельца:</label><input type="text" id="teleph" runat="server"/>
        </div>
        
        <div>
            <button type="submit">Оформить</button>
        </div>
    </form>
</body>
</html>
