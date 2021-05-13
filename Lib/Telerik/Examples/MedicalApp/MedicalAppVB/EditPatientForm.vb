Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Windows.Forms

Imports Telerik.WinControls
Imports Telerik.WinControls.Enumerations
Imports Telerik.WinControls.UI

Namespace MedicalAppCS
	Public Partial Class EditPatientForm
		Inherits RadForm
		Private personId As Integer
		Private errorProvider As ErrorProvider
		Private isPuctureBoxValueChanged As Boolean = False

		Public Sub New()
			InitializeComponent()
			Me.errorProvider = New ErrorProvider()
		End Sub

		Private Sub photoBrowseEditor_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles photoBrowseEditor.ValueChanged
			Me.isPuctureBoxValueChanged = True
		End Sub

		Private Sub EditPatientForm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Me.personsTableAdapter1.Fill(DataSources.PatientsDataSet.Persons)

			Me.personId = Integer.Parse(Me.Tag.ToString())
			Dim person As PatientsDataSet.PersonsRow = DataSources.PatientsDataSet.Persons.FindById(Me.personId)
			If Not person("FirstName") Is DBNull.Value Then
				Me.firstNameTextBoxControl.Text = person.FirstName
			End If
			If Not person("MiddleName") Is DBNull.Value Then
				Me.middleNameTextBoxControl.Text = person.MiddleName
			End If
			If Not person("FamilyName") Is DBNull.Value Then
				Me.lastNameTextBoxControl.Text = person.FamilyName
			End If
			If Not person("Gender") Is DBNull.Value Then
				If person.Gender = "M" Then
					Me.genderMaleRadioButton.ToggleState = ToggleState.On
				Else
					Me.genderFemaleRadioButton.ToggleState = ToggleState.On
				End If
			End If
			If Not person("BirthDate") Is DBNull.Value Then
				Me.birthDateDateTimePicker.Value = person.BirthDate
			End If
			If Not person("City") Is DBNull.Value Then
				Me.cityTextBoxControl.Text = person.City
			End If
			If Not person("State") Is DBNull.Value Then
				Me.stateTextBoxControl.Text = person.State
			End If
			If Not person("Address") Is DBNull.Value Then
				Me.addressTextBoxControl.Text = person.Address
			End If
			If Not person("PostalCode") Is DBNull.Value Then
				Me.postalCodeTextBoxControl.Text = person.PostalCode
			End If
			If Not person("Phone") Is DBNull.Value Then
				Me.phoneMaskedEditBox.Text = person.Phone
			End If
		End Sub

		Private Function AreRequiredFieldsValid() As Boolean
			If String.IsNullOrEmpty(Me.firstNameTextBoxControl.Text) Then
				Me.errorProvider.SetError(Me.firstNameTextBoxControl, "First Name is required.")
				Return False
			End If
			If String.IsNullOrEmpty(Me.middleNameTextBoxControl.Text) Then
				Me.errorProvider.SetError(Me.middleNameTextBoxControl, "Middle Name is required.")
				Return False
			End If
			If String.IsNullOrEmpty(Me.lastNameTextBoxControl.Text) Then
				Me.errorProvider.SetError(Me.lastNameTextBoxControl, "Last Name is required.")
				Return False
			End If
			If Me.birthDateDateTimePicker.DateTimePickerElement.Value Is Nothing Then
				Me.errorProvider.SetError(Me.birthDateDateTimePicker, "Birth date is required.")
				Return False
			End If

			Return True
		End Function

		Private Sub saveButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles saveButton.Click
			If (Not Me.AreRequiredFieldsValid()) Then
				Return
			End If

			Dim person As PatientsDataSet.PersonsRow = DataSources.PatientsDataSet.Persons.FindById(Me.personId)
			person.FirstName = Me.firstNameTextBoxControl.Text
			person.MiddleName = Me.middleNameTextBoxControl.Text
			person.FamilyName = Me.lastNameTextBoxControl.Text
			If Me.genderMaleRadioButton.ToggleState = ToggleState.On Then
				person.Gender = "M"
			Else
				person.Gender = "F"
			End If
			person.BirthDate = Me.birthDateDateTimePicker.Value
			person.City = Me.cityTextBoxControl.Text
			person.State = Me.stateTextBoxControl.Text
			person.Address = Me.addressTextBoxControl.Text
			person.PostalCode = Me.postalCodeTextBoxControl.Text
			person.Phone = Me.phoneMaskedEditBox.Text

			Dim imagePath As String = Me.photoBrowseEditor.Value
			If Me.isPuctureBoxValueChanged Then
				person.PersonImageId = -1
			End If

			If (Not String.IsNullOrEmpty(imagePath)) Then
				Dim image As Image = Image.FromFile(imagePath)
				Dim bitmap As Bitmap = New Bitmap(image, New Size(120, 120))
				Dim imageConverter As ImageConverter = New ImageConverter()
				Dim bytes As Byte() = CType(imageConverter.ConvertTo(bitmap, GetType(Byte())), Byte())
				Dim personImageRow As PatientsDataSet.PersonImagesRow = CType(DataSources.PatientsDataSet.PersonImages.Rows.Add(), PatientsDataSet.PersonImagesRow)
				personImageRow.Picture = bytes
				Me.personImagesTableAdapter1.Update(DataSources.PatientsDataSet.PersonImages)
				Dim data As PatientsDataSet.PersonImagesDataTable = Me.personImagesTableAdapter1.GetData()
				personImageRow = data(data.Count - 1)
				person.PersonImageId = personImageRow.Id
			End If

			Me.personsTableAdapter1.Update(DataSources.PatientsDataSet.Persons)
			Me.personsTableAdapter1.Fill(DataSources.PatientsDataSet.Persons)
			If Me.isPuctureBoxValueChanged Then
				Me.personImagesTableAdapter1.Fill(DataSources.PatientsDataSet.PersonImages)
			End If
			Me.patientsTableAdapter1.Fill(DataSources.PatientsDataSet.Patients)
			RadMessageBox.Show(Me, "Patient information saved.")
			Me.Close()
		End Sub

		Private Sub cancelButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cancelButton.Click
			Me.Close()
		End Sub
	End Class
End Namespace
