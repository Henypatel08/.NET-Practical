<%@ Page Language="C#" AutoEventWireup="true"
    CodeBehind="EVENTREGISTRATION.aspx.cs"
    Inherits="PRECTICAL4.EVENTREGISTRATION" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">

    <title>Event Registration Form</title>

    <link href="StyleSheet1.css" rel="stylesheet" />

    <script type="text/javascript">

        function validateDepartment(source, args) {

            args.IsValid =
                document.getElementById('<%= RadioButton1.ClientID %>').checked ||
                document.getElementById('<%= RadioButton2.ClientID %>').checked ||
                document.getElementById('<%= RadioButton3.ClientID %>').checked ||
                document.getElementById('<%= RadioButton4.ClientID %>').checked ||
                document.getElementById('<%= RadioButton5.ClientID %>').checked;
        }


        function validateGender(source, args) {

            args.IsValid =
                document.getElementById('<%= RadioButton6.ClientID %>').checked ||
                document.getElementById('<%= RadioButton7.ClientID %>').checked;
        }


        function validateTerms(source, args) {

            args.IsValid =
        document.getElementById('<%= CheckBox5.ClientID %>').checked;
}

</script>

</head>


<body>

    <form id="form1" runat="server">

        <div class="container">

            <h2>EVENT REGISTRATION FORM</h2>

            <table class="registration-table">


                <!-- FULL NAME -->

                <tr>

                    <td>
                        <asp:Label
                            ID="Label1"
                            runat="server"
                            Text="FULL NAME">
                        </asp:Label>
                    </td>

                    <td>:</td>

                    <td>
                        <asp:TextBox
                            ID="TextBox1"
                            runat="server">
                        </asp:TextBox>
                    </td>

                    <td>

                        <asp:RequiredFieldValidator
                            ID="RequiredFieldValidator1"
                            runat="server"
                            ErrorMessage="Please Enter Your Name"
                            ForeColor="Red"
                            ControlToValidate="TextBox1">
                        </asp:RequiredFieldValidator>

                    </td>

                </tr>


                <!-- E-MAIL -->

                <tr>

                    <td>
                        <asp:Label
                            ID="Label2"
                            runat="server"
                            Text="E-MAIL ID">
                        </asp:Label>
                    </td>

                    <td>:</td>

                    <td>
                        <asp:TextBox
                            ID="TextBox2"
                            runat="server">
                        </asp:TextBox>
                    </td>

                    <td>

                        <asp:RequiredFieldValidator
                            ID="RequiredFieldValidator2"
                            runat="server"
                            ControlToValidate="TextBox2"
                            ErrorMessage="Please Enter Your Email"
                            ForeColor="Red">
                        </asp:RequiredFieldValidator>

                        <asp:RegularExpressionValidator
                            ID="RegularExpressionValidator1"
                            runat="server"
                            ControlToValidate="TextBox2"
                            ValidationExpression="^[^@\s]+@[^@\s]+\.[^@\s]+$"
                            ErrorMessage="Enter valid email"
                            ForeColor="Red">
                        </asp:RegularExpressionValidator>

                    </td>

                </tr>


                <!-- CONTACT NO -->

                <tr>

                    <td>
                        <asp:Label
                            ID="Label3"
                            runat="server"
                            Text="CONTACT NO">
                        </asp:Label>
                    </td>

                    <td>:</td>

                    <td>
                        <asp:TextBox
                            ID="TextBox3"
                            runat="server">
                        </asp:TextBox>
                    </td>

                    <td>

                        <asp:RequiredFieldValidator
                            ID="RequiredFieldValidator3"
                            runat="server"
                            ControlToValidate="TextBox3"
                            ErrorMessage="Contact number is required"
                            ForeColor="Red">
                        </asp:RequiredFieldValidator>

                        <asp:RegularExpressionValidator
                            ID="RegularExpressionValidator2"
                            runat="server"
                            ControlToValidate="TextBox3"
                            ValidationExpression="^[0-9]{10}$"
                            ErrorMessage="* Enter valid 10 digit contact number"
                            ForeColor="Red">
                        </asp:RegularExpressionValidator>

                    </td>

                </tr>


                <!-- DATE OF BIRTH -->

                <tr>

                    <td>
                        <asp:Label
                            ID="Label5"
                            runat="server"
                            Text="DATE OF BIRTH">
                        </asp:Label>
                    </td>

                    <td>:</td>

                    <td>

                        <asp:Calendar
                            ID="Calendar1"
                            runat="server">
                        </asp:Calendar>

                    </td>

                    <td>

                        <asp:CustomValidator
                            ID="CustomValidatorDOB"
                            runat="server"
                            ErrorMessage="Please select Date of Birth"
                            ForeColor="Red"
                            OnServerValidate="CustomValidatorDOB_ServerValidate">
                        </asp:CustomValidator>

                    </td>

                </tr>


                <!-- COLLEGE NAME -->

                <tr>

                    <td>
                        <asp:Label
                            ID="Label4"
                            runat="server"
                            Text="COLLEGE NAME">
                        </asp:Label>
                    </td>

                    <td>:</td>

                    <td>

                        <asp:TextBox
                            ID="TextBox4"
                            runat="server">
                        </asp:TextBox>

                    </td>

                    <td>

                        <asp:RequiredFieldValidator
                            ID="RequiredFieldValidator4"
                            runat="server"
                            ErrorMessage="Please Enter Your Collage Name"
                            ForeColor="Red"
                            ControlToValidate="TextBox4">
                        </asp:RequiredFieldValidator>

                    </td>

                </tr>


                <!-- DEPARTMENT -->

                <tr>

                    <td>DEPARTMENT</td>

                    <td>:</td>

                    <td>

                        <asp:RadioButton
                            ID="RadioButton1"
                            runat="server"
                            Text="COMPUTER"
                            GroupName="DEPARTMENT" />

                        <br />

                        <asp:RadioButton
                            ID="RadioButton2"
                            runat="server"
                            Text="MECHANICAL"
                            GroupName="DEPARTMENT" />

                        <br />

                        <asp:RadioButton
                            ID="RadioButton3"
                            runat="server"
                            Text="ICT"
                            GroupName="DEPARTMENT" />

                        <br />

                        <asp:RadioButton
                            ID="RadioButton4"
                            runat="server"
                            Text="CHEMICAL"
                            GroupName="DEPARTMENT" />

                        <br />

                        <asp:RadioButton
                            ID="RadioButton5"
                            runat="server"
                            Text="CIVIL"
                            GroupName="DEPARTMENT" />

                    </td>

                    <td>

                        <asp:CustomValidator
                            ID="CustomValidator1"
                            runat="server"
                            ErrorMessage="Please select department"
                            ForeColor="Red"
                            ClientValidationFunction="validateDepartment">
                        </asp:CustomValidator>

                    </td>

                </tr>


                <!-- EVENT -->

                <tr>

                    <td>
                        <asp:Label
                            ID="Label6"
                            runat="server"
                            Text="EVENT">
                        </asp:Label>
                    </td>

                    <td>:</td>

                    <td>

                        <asp:DropDownList
                            ID="DropDownList1"
                            runat="server">

                            <asp:ListItem
                                Enabled="true"
                                Text="SELECT EVENT"
                                Value="-1">
                            </asp:ListItem>

                            <asp:ListItem
                                Text="CODING"
                                Value="1">
                            </asp:ListItem>

                            <asp:ListItem
                                Text="HACKATHON"
                                Value="2">
                            </asp:ListItem>

                            <asp:ListItem
                                Text="TREASURE HUNT"
                                Value="3">
                            </asp:ListItem>

                            <asp:ListItem
                                Text="SPY"
                                Value="4">
                            </asp:ListItem>

                        </asp:DropDownList>

                    </td>

                    <td>

                        <asp:RequiredFieldValidator
                            ID="RequiredFieldValidator5"
                            runat="server"
                            ControlToValidate="DropDownList1"
                            InitialValue="-1"
                            ErrorMessage="Please select an event"
                            ForeColor="Red">
                        </asp:RequiredFieldValidator>

                    </td>

                </tr>


                <!-- GENDER -->

                <tr>

                    <td>GENDER</td>

                    <td>:</td>

                    <td>

                        <asp:RadioButton
                            ID="RadioButton6"
                            runat="server"
                            Text="MALE"
                            GroupName="GENDER" />

                        <asp:RadioButton
                            ID="RadioButton7"
                            runat="server"
                            Text="FEMALE"
                            GroupName="GENDER" />

                    </td>

                    <td>

                        <asp:CustomValidator
                            ID="CustomValidator2"
                            runat="server"
                            ErrorMessage="Please select gender"
                            ForeColor="Red"
                            ClientValidationFunction="validateGender">
                        </asp:CustomValidator>

                    </td>

                </tr>


                <!-- SKILLS -->

                <tr>

                    <td>SKILLS</td>

                    <td>:</td>

                    <td>

                        <asp:CheckBox
                            ID="CheckBox1"
                            runat="server"
                            Text="C" />

                        <asp:CheckBox
                            ID="CheckBox2"
                            runat="server"
                            Text="C#" />

                        <asp:CheckBox
                            ID="CheckBox3"
                            runat="server"
                            Text="C++" />

                        <asp:CheckBox
                            ID="CheckBox4"
                            runat="server"
                            Text="Java" />

                    </td>

                    <td>
                    </td>

                </tr>


                <!-- ADDRESS -->

                <tr>

                    <td>ADDRESS</td>

                    <td>:</td>

                    <td>

                        <asp:TextBox
                            ID="TextBox5"
                            runat="server"
                            TextMode="MultiLine"
                            Rows="4"
                            Columns="30">
                        </asp:TextBox>

                    </td>

                    <td>

                        <asp:RequiredFieldValidator
                            ID="RequiredFieldValidator6"
                            runat="server"
                            ControlToValidate="TextBox5"
                            ErrorMessage="Address is required"
                            ForeColor="Red">
                        </asp:RequiredFieldValidator>

                    </td>

                </tr>


                <!-- TERMS -->

                <tr>

                    <td>TERMS</td>

                    <td>:</td>

                    <td>

                        <asp:CheckBox
                            ID="CheckBox5"
                            runat="server"
                            Text="I ACCEPT TERMS &amp; CONDITIONS" />

                    </td>

                    <td>

                        <asp:CustomValidator
                            ID="CustomValidator3"
                            runat="server"
                            ErrorMessage="Please accept terms and conditions"
                            ForeColor="Red"
                            ClientValidationFunction="validateTerms">
                        </asp:CustomValidator>

                    </td>

                </tr>


                <!-- BUTTONS -->

                <tr>

                    <td></td>

                    <td></td>

                    <td>

                        <asp:Button
                            ID="Button1"
                            runat="server"
                            Text="SUBMIT"
                            OnClick="submitbtn" />

                        <asp:Button
                            ID="Button2"
                            runat="server"
                            Text="CLEAR"
                            OnClick="clearbtn" />

                    </td>

                </tr>


                <!-- OUTPUT -->

                <tr>

                    <td colspan="3">

                        <hr />

                        <asp:Label
                            ID="Label11"
                            runat="server"
                            Text="">
                        </asp:Label>

                    </td>

                </tr>


            </table>

        </div>

    </form>

</body>

</html>