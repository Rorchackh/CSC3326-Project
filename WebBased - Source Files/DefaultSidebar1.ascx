<%@ Control Language="C#" AutoEventWireup="true" CodeFile="DefaultSidebar1.ascx.cs" Inherits="Sidebar1" %>
<%@ Import Namespace="Artisteer" %>
<%@ Register TagPrefix="artisteer" Namespace="Artisteer" %>
<%@ Register TagPrefix="art" TagName="DefaultVerticalMenu" Src="DefaultVerticalMenu.ascx" %>

<art:DefaultVerticalMenu ID="DefaultVMenuContent" runat="server" />
                  <artisteer:Block ID="HighlightsBlock" Caption="Highlights" runat="server"><ContentTemplate><div>
                            <ul><li><b>Jan 14, 2010</b>
                            <p>At the beginning of spring 2010, The Pirkt project was launched...<br />
                            </p></li></ul>
                            <ul><li><b>May 1, 2010</b>
                            <p>The project is almost done...<br />
                            </p></li></ul>
                            </div>
             </ContentTemplate></artisteer:Block>
