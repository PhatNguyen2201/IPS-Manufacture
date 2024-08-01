using CreateFolderManufacture;
using System;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace ExoSendTo3DPrint
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            try
            {
                if (!args[0].EndsWith(".dentalProject"))
                {
                    MessageBox.Show("Vui lòng mở với file dentalProject");
                    return;
                }
                MaterialSelect materialSelect = new MaterialSelect();
                materialSelect.ShowDialog();
                if (materialSelect.Selected == false)
                {
                    return;
                }
                DatabaseFunctions.Enumarable.EMaterial MaterialSelected = materialSelect.MaterialName;
                Treatment projectInfo = new Treatment();
                FileStream fs = new FileStream(args[0], FileMode.Open, FileAccess.Read);
                try
                {
                    XmlSerializer sr = new XmlSerializer(typeof(Treatment));
                    object result = sr.Deserialize(fs);
                    fs.Close();
                    projectInfo = (Treatment)result;
                }
                catch (Exception e)
                {
                    fs.Close();
                    _ = MessageBox.Show(e.Message, "Lỗi");
                    return;
                }
                int labID = materialSelect.LabOutsource;
                int trm_id = Get_trmID(projectInfo);
                DatabaseFunctions.Enumarable.EManufactureStatus manufactureStatus = materialSelect.ManuStatus;
                string NoteReason = materialSelect.NoteReason;
                string dateTimeNow = DateTime.Now.ToString("yy-MM-dd HH-mm-ss");
                string currentDIR = args[0].Substring(0, args[0].LastIndexOf("\\"));
                DirectoryInfo directoryInfo = new DirectoryInfo(currentDIR);
                CreateFolderManufacture.Class1 class1 = new CreateFolderManufacture.Class1();
                DirectoryInfo parentDIR = class1.ManufactureFolder(projectInfo.Practice.PracticeId, projectInfo.Practice.PracticeName, projectInfo.Patient.PatientName, projectInfo.Patient.PatientFirstName);
                DirectoryInfo PrintDIR = parentDIR.CreateSubdirectory("3dPrint");
                DirectoryInfo PrintNow = PrintDIR.CreateSubdirectory(dateTimeNow);
                foreach (FileInfo file in directoryInfo.GetFiles())
                {
                    if (file.Name.EndsWith("cad.stl"))
                    {
                        string destDIR = PrintNow.FullName + "\\" + file.Name;
                        File.Copy(file.FullName, destDIR, true);
                        continue;
                    }
                    if (file.Name.EndsWith(".constructionInfo"))
                    {
                        string destDIR = PrintNow.FullName + "\\" + file.Name;
                        File.Copy(file.FullName, destDIR, true);
                    }
                }
                DatabaseFunctions.DataAccess.DataSendto dataSendto = new DatabaseFunctions.DataAccess.DataSendto();
                dataSendto.AddNewRow(DateTime.Now, projectInfo.Patient.PatientName, projectInfo.Practice.PracticeName, projectInfo.Patient.PatientFirstName, DatabaseFunctions.Enumarable.EManufactureType.Print3D, manufactureStatus, MaterialSelected, PrintNow.FullName, DatabaseFunctions.Enumarable.EProgress.None, labID, trm_id, NoteReason);
                MessageBox.Show("Đã xuất file in 3d phục hình");
                Process.Start("explorer.exe", PrintNow.FullName);
            }
            catch (Exception error)
            {
                MessageBox.Show($"Error: {error}","Lỗi");
            }
        }
        private static int Get_trmID(Treatment treatment)
        {
            try
            {
                string queryCheckDuplicate = "Select * from treatment where projectGUID = '" + treatment.ProjectGUID + "'";
                DataTable tableCheckDuplicate = DatabaseFunctions.MicrosoftSQLFunction.Instance.ExQuery(queryCheckDuplicate);
                if (tableCheckDuplicate.Rows.Count == 1)
                {
                    bool check1 = tableCheckDuplicate.Rows[0]["patient_practice_id"].ToString() == treatment.Practice.PracticeId.ToString();
                    bool check2 = tableCheckDuplicate.Rows[0]["patient_patient_id"].ToString() == treatment.Patient.PatientId.ToString();
                    if (check1 && check2)
                    {
                        return Convert.ToInt32(tableCheckDuplicate.Rows[0]["treatment_id"]);
                    }
                    else
                    {
                        return Get_trmID_byPatient(treatment.Patient.PatientId, treatment.Practice.PracticeId);
                    }
                }
                else
                {
                    throw new Exception("Không thể mở thiết kế do tệp không có trong cơ sở dữ liệu hoặc bị lỗi trùng projectGUID. Liên hệ nhà phát triển để sửa lỗi");
                }
            }
            catch (Exception ex)
            {
                return -1;
            }
        }
        private static int Get_trmID_byPatient(int patientID, int practiceID)
        {
            string query = "Select * from treatment where patient_practice_id = " + practiceID + " and patient_patient_id = " + patientID;
            DataTable getTableTreatment = DatabaseFunctions.MicrosoftSQLFunction.Instance.ExQuery(query);
            if (getTableTreatment.Rows.Count == 1)
            {
                return Convert.ToInt32(getTableTreatment.Rows[0]["treatment_id"]);
            }
            else
            {
                throw new Exception("Không thể lấy được trm_ID từ patientID, hãy thử thực hiện chỉnh sửa project hiện tại và ấn Save, vấn đề có thể được giải quyết");
            }
        }
    }
}
