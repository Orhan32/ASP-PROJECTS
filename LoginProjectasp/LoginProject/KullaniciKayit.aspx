<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="KullaniciKayit.aspx.cs" Inherits="LoginProject.KullaniciKayit" %>

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
                        <div class="card-header">Kayıt Formu</div>
                        <div class="card-body">
                            <div class="form-group row">
                                <label for="full_name" class="col-md-4 col-form-label text-md-right">Adı :</label>
                                <div class="col-md-6">
                                    <asp:TextBox ID="txt_adi" runat="server" CssClass="form-control"></asp:TextBox>
                                </div>
                            </div>
                            <div class="form-group row">
                                <label for="full_name" class="col-md-4 col-form-label text-md-right">Soyadı :</label>
                                <div class="col-md-6">
                                    <asp:TextBox ID="txt_soyadi" runat="server" CssClass="form-control"></asp:TextBox>
                                </div>
                            </div>
                            <div class="form-group row">
                                <label for="full_name" class="col-md-4 col-form-label text-md-right">TC :</label>
                                <div class="col-md-6">
                                    <asp:TextBox ID="txt_tc" runat="server" CssClass="form-control"></asp:TextBox>
                                </div>
                            </div>
                            <div class="form-group row">
                                <label for="full_name" class="col-md-4 col-form-label text-md-right">Telefon No :</label>
                                <div class="col-md-6">
                                    <asp:TextBox ID="txt_telefon" runat="server" CssClass="form-control"></asp:TextBox>
                                </div>
                            </div>
                            <div class="form-group row">
                                <label for="email_address" class="col-md-4 col-form-label text-md-right">E-Mail</label>
                                <div class="col-md-6">
                                    <input type="text" runat="server" id="txt_email" class="form-control" name="email-address">
                                </div>
                            </div>

                            <div class="form-group row">
                                <label for="user_name" class="col-md-4 col-form-label text-md-right">Kullanıcı Adı</label>
                                <div class="col-md-6">
                                    <input type="text" runat="server" id="txt_kullaniciAdi" class="form-control" name="username">
                                </div>
                            </div>

                            <div class="form-group row">
                                <label for="phone_number" class="col-md-4 col-form-label text-md-right">Şifre</label>
                                <div class="col-md-6">
                                    <input type="password" runat="server" id="txt_sifre" class="form-control">
                                </div>
                            </div>




                            <div class="col-md-6 offset-md-4">
                                <asp:Button ID="btn_kaydet" runat="server" Text="Kaydet" class="btn btn-primary" OnClick="btn_kaydet_Click" Width="210px" />

                            </div>
                        </div>
                    </div>
                    </div>
                </div>
            </div>
    </form>
</body>
</html>
