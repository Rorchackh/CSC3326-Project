<%@ Control Language="C#" AutoEventWireup="true" CodeFile="DefaultSidebar2.ascx.cs" Inherits="Sidebar2" %>
<%@ Import Namespace="Artisteer" %>
<%@ Register TagPrefix="artisteer" Namespace="Artisteer" %>
<artisteer:Block ID="NewsletterBlock" Caption="Newsletter" runat="server"><ContentTemplate><div>
          <input ID="emailBlock" type="text" value="" name="email" id="s" style="width: 95%;" />
          <input id="submit" type="button" value="Subscribe" class="art-button" onclick="window.location='Subscribed.aspx?email=kaka'" />
          
          &nbsp;<span class="art-button-wrapper"><span class="l"></span><span class="r"></span>
          </span>
          </div>
             </ContentTemplate></artisteer:Block><artisteer:Block ID="ContactInformationBlock" Caption="Contact Info" runat="server"><ContentTemplate><div>
                <img src="images/contact.jpg" alt="an image" style="margin: 0 auto;display:block;width:95%" />
          <br />
          <b>DB Company Co.</b><br />
          Ifrane, Morocco 53000<br />
          Email: <a href="mailto:csc3326@aui.ma">csc3326@aui.ma</a><br />
          <br />
          Phone: (212) 53586-2222 <br />
          Fax: (212) 53586-2223
          </div>
             </ContentTemplate></artisteer:Block>
