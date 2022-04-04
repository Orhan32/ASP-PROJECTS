<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="KullaniciGiris.aspx.cs" Inherits="LoginProject.KullaniciGiris" %>

<!DOCTYPE html>
<link href="//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/css/bootstrap.min.css" rel="stylesheet" id="bootstrap-css">
<script src="//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/js/bootstrap.min.js"></script>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
           <div class="cotainer">
            <div class="row justify-content-center">
                <div class="col-md-8">
                    <div class="card">
                        <div class="card-header">Kullanıcı Giriş</div>
                        <div class="card-body">
                                <div class="form-group row">
                                    <label for="email_address" class="col-md-4 col-form-label text-md-right">Kullanıcı Adı</label>
                                    <div class="col-md-6">
                                        <asp:TextBox ID="txt_kullaniciAdi" runat="server" CssClass="form-control"></asp:TextBox>
                                    </div>
                                </div>

                                <div class="form-group row">
                                    <label for="password" class="col-md-4 col-form-label text-md-right">Şifre</label>
                                    <div class="col-md-6">
                                        <asp:TextBox ID="txt_sifre" runat="server" CssClass="form-control" TextMode="Password"></asp:TextBox>
                                    </div>
                                </div>



                                <div class="col-md-6 offset-md-4">
                                    <asp:Button ID="btn_kayit" CssClass="btn btn-primary" runat="server" Text="Kaydol" OnClick="btn_kayit_Click" />
                                    <asp:Button ID="btn_giris" CssClass="btn btn-success" runat="server" Text="Giriş" OnClick="btn_giris_Click" />

                                    <a href="#" class="btn btn-link">Şifremi Unuttum
                                </a>
                                    <asp:Label ID="lbl_sonuc" runat="server" Text="Label"></asp:Label>
                                </div>
                        </div>
    </form>
</body>
</html>
