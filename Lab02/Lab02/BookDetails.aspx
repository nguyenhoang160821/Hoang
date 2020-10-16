<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="BookDetails.aspx.cs" Inherits="Lab02.BookDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:FormView ID="bookDetail" runat="server" ItemType="Lab02.Models.Book" SelectMethod ="GetBook" RenderOuterTable="false">
        <ItemTemplate>
            <div>
                <h1><%#:Item.BookName %></h1>
            </div>
            <br />
            <table>
                <tr>
                    <td>
                        <img src="/BooksLibrary/<%#:Item.ImagePath %>" style="border:solid; height:300px" alt="<%#:Item.BookName %>"/>
                    </td>
                    <td>&nbsp;</td>  
                    <td style="vertical-align: top; text-align:left;">
                        <b>Description:</b><br /><%#:Item.Description %>
                        <br />                      
                        <span><b>Book Number:</b>&nbsp;<%#:Item.BookID %></span>
                        <br />
                    </td>
                </tr>
            </table>
        </ItemTemplate>
    </asp:FormView>
</asp:Content>
