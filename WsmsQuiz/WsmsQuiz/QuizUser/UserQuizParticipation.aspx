<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UserQuizParticipation.aspx.cs" Inherits="WsmsQuiz.QuizUser.UserQuizParticipation" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link href="../Content/bootstrap.css" rel="stylesheet" />
    <div class="container">
        <div class="row">
            <div class="col-lg-2">
                <h2>Hi
                    <asp:Label ID="lblUser" runat="server" Text="TestSksdh" ClientIDMode="Static"></asp:Label></h2>
            </div>
            <div class="col-lg-4">
            </div>

        </div>
        <div class="row">
            <div class="panel panel-danger">
                <div class="panel-heading">
                    <h3 class="panel-title">You have
                        <asp:Label ID="lblNoOfQuestion" runat="server" Text="5" ClientIDMode="Static"></asp:Label></h3>
                </div>

                <div class="panel-body">
                    <%-- Added question here --%>
                    <%--<div id="jsGrid"></div>--%>
                    <div class="row">
                        <div class="col-lg-2">
                           <h3>Qustion Name:</h3>
                        </div>
                        <%--<div class="col-lg-4">
                            Answer:
                        </div>--%>

                    </div>
                    <div class="row">
                        <div class="col-lg-2">
                         <h4>  Answer:</h4>
                        </div>
                        <%--<div class="col-lg-4">
                            Answer:
                        </div>--%>

                    </div>
                    <div>
                        <asp:PlaceHolder ID="phDynamicQuestion" runat="server"></asp:PlaceHolder>
                    </div>

                </div>
            </div>
        </div>

    </div>
</asp:Content>
