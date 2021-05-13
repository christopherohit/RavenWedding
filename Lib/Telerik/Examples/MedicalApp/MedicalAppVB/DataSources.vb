Imports Microsoft.VisualBasic
Imports System

Namespace MedicalAppCS
    Public Class DataSources
        Public Shared Property PatientsDataSet() As PatientsDataSet
            Get
                Return m_PatientsDataSet
            End Get
            Set(value As PatientsDataSet)
                m_PatientsDataSet = value
            End Set
        End Property
        Private Shared m_PatientsDataSet As PatientsDataSet
    End Class
End Namespace
