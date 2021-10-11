<%@ Page Title="" Language="C#" MasterPageFile="~/InicioSesion_Registrarse.Master" AutoEventWireup="true" CodeBehind="Registrarse.aspx.cs" Inherits="Proyecto_PWIII.Registrarse" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style type="text/css">

        *, *:before, *:after {
            box-sizing: border-box;
        }

        html {
            overflow-y: scroll;
        }

        body {
            background: #c1bdba;
            font-family: 'Titillium Web', sans-serif;
        }

        a {
            text-decoration: none;
            color: #1ab188;
            transition: .5s ease;
        }

        .form {
            padding: 40px;
            max-width: 600px;
            margin: 40px auto;
            border-radius: 4px;
        }

        .tab-group {
            list-style: none;
            padding: 0;
            margin: 0 0 40px 0;
        }

        li a {
            display: block;
            text-decoration: none;
            padding: 15px;
            color: #a0b3b0;
            font-size: 20px;
            float: left;
            width: 50%;
            text-align: center;
            cursor: pointer;
            transition: .5s ease;

        }

        .active a {
            background: #1ab188;
            color: #ffffff;
        }


        h1 {
            text-align: center;
            color: #ffffff;
            font-weight: 300;
            margin: 0 0 40px;
        }

        label {
            position: absolute;
            transform: translateY(6px);
            left: 13px;
            transition: all 0.25s ease;
            -webkit-backface-visibility: hidden;
            pointer-events: none;
            font-size: 22px;

        }

        label.active {
            transform: translateY(50px);
            left: 2px;
            font-size: 14px;
        }

        label.highlight {
            color: #ffffff;
        }

        input, textarea {
            font-size: 22px;
            display: block;
            width: 100%;
            height: 100%;
            padding: 5px 10px;
            background: none;
            background-image: none;
            border: 1px solid #a0b3b0;
            color: #ffffff;
            border-radius: 0;
            transition: border-color .25s ease, box-shadow .25s ease;
        }

        textarea {
            border: 2px solid #a0b3b0;
            resize: vertical;
        }

        .field-wrap {
            position: relative;
            margin-bottom: 40px;
        }

        .div {
            float: left;
            width: 48%;
            margin-right: 4%;
        }

        .button {
            color: black;
            border:thick;
            outline: none;
            border-radius: 0;
            padding: 15px 0;
            font-size: small;
            font-weight: bold;
            text-transform: uppercase;
            letter-spacing: .1em;
            background: center;
            color: #ffffff;
            transition: all.5s ease;
            -webkit-appearance: none;

        }

        .button-block {
            color: black;
            display: block;
            width: 100%;
            background-color: red;
        }

        .forgot {
            margin-top: -20px;
            text-align: right;
        }
        .auto-style1 {
            left: 10px;
            top: 7px;
        }
        .auto-style2 {
            left: 2px;
            top: -32px;
        }
    </style>
    <div class="form">
            <div id="signup">
                <h1>REGISTRARSE</h1>

                <div action="/" method="post">

                    <div class="field-wrap">
                        <div class="field-wrap">
                            <label class="auto-style2">
                                Nombre<span class="req">*</span>
                            </label>
                            <input type="text" id="txtName" required autocomplete="off" />
                        </div>

                        <div class="field-wrap">
                            <label class="auto-style2">
                                Apellido Paterno<span class="req">*</span>
                            </label>
                            <input type="text" id="txtLastName" required autocomplete="off" />
                        </div>
                    </div>

                    <div class="field-wrap">
                        <label class="auto-style2">
                            Apellido Materno<span class="req"></span>
                        </label>
                        <input type="text" id="txtSecondLastName" autocomplete="off" />
                    </div>

                    <div class="field-wrap">
                        <label class="auto-style2">
                            Correo Electrónico<span class="req">*</span>
                        </label>
                        <input type="email" id="txtEmail" required autocomplete="off" />
                    </div>

                    <div class="field-wrap">
                        <label class="auto-style2">
                            Contraseña<span class="req">*</span>
                        </label>
                        <input type="password" id="txtPassword" required autocomplete="off" />
                    </div>

                    <div class="field-wrap">
                        <label class="auto-style2">
                            Confirmar Contraseña<span class="req">*</span>
                        </label>
                        
                        <input type="password" id="txtConfirmPassword" required autocomplete="off" />
                    </div>

                    <button type="submit" id="btnRegister" class="button button-block">REGISTRARSE</button>
                </div>
            </div>
        </div>
</asp:Content>
