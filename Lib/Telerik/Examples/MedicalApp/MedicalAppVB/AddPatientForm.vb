Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Windows.Forms

Imports Telerik.WinControls
Imports Telerik.WinControls.Enumerations
Imports Telerik.WinControls.UI

Namespace MedicalAppCS
	Public Partial Class AddPatientForm
		Inherits RadForm
		Private errorProvider As ErrorProvider

		Public Sub New()
			InitializeComponent()
			Me.errorProvider = New ErrorProvider()
            TryCast(Me.photoBrowseEditor.BrowseDialog, OpenFileDialog).Filter = "Image Files|*.jpeg;*.png;*.jpg;*.gif"
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

			Dim person As PatientsDataSet.PersonsRow = CType(DataSources.PatientsDataSet.Persons.Rows.Add(), PatientsDataSet.PersonsRow)
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
			Me.patientsTableAdapter1.Fill(DataSources.PatientsDataSet.Patients)
			Me.personsTableAdapter1.Fill(DataSources.PatientsDataSet.Persons)
			Me.personImagesTableAdapter1.Fill(DataSources.PatientsDataSet.PersonImages)
			RadMessageBox.Show(Me, "Patient added.")
			Me.Close()
		End Sub

		Private Sub cancelButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cancelButton.Click
			Me.Close()
		End Sub
	End Class
End Namespace
