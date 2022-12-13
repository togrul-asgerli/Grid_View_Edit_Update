<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="First.aspx.cs" Inherits="Grid_View_Edit.First" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:GridView ID="grid_list" runat="server" AutoGenerateColumns="false" OnRowDeleting="delete_action" OnRowEditing="edit_action" OnRowUpdating="update_action" OnRowCancelingEdit="edit_cancel">
                <Columns>
                    <asp:BoundField DataField="CustomerId" HeaderText="İD" />
                    <asp:BoundField DataField="ContactName" HeaderText="Ad" />
                    <asp:BoundField DataField="Address" HeaderText="Ünvan" />
                    <asp:BoundField DataField="City" HeaderText="Şəhər" />
                    <asp:CommandField ShowEditButton="true" />
                    <asp:CommandField ShowDeleteButton="true" />
                </Columns>
            </asp:GridView>

        </div>
    </form>
</body>
</html>
