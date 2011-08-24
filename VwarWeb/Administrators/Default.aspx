<%--
Copyright 2011 U.S. Department of Defense

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
--%>



<%@ Page Title="" Language="C#" MasterPageFile="~/Administrator.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Administrators_Default" %>

<%@ Register src="~/Controls/CybrarianQueue.ascx" tagname="CybrarianQueue" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="AdminContentPlaceHolder" Runat="Server">


<div style="width: 790px; margin: auto;">
    
<uc1:CybrarianQueue ID="CybrarianQueue1" runat="server" />

</div>
    

</asp:Content>

