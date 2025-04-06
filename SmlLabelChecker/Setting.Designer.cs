using System.ComponentModel;

namespace SmlLabelChecker
{
    partial class Setting
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Setting));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.HospitalTextBox = new System.Windows.Forms.TextBox();
            this.CloseButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.LabelSettingDrop = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LabelSettingDataView = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TestCodeTextBox = new System.Windows.Forms.TextBox();
            this.resultContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("돋움", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(12, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "공통 세팅";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("돋움", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(141, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 26);
            this.label2.TabIndex = 13;
            this.label2.Text = "병원에서";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HospitalTextBox
            // 
            this.HospitalTextBox.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.HospitalTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.HospitalTextBox.Location = new System.Drawing.Point(23, 56);
            this.HospitalTextBox.Name = "HospitalTextBox";
            this.HospitalTextBox.Size = new System.Drawing.Size(112, 26);
            this.HospitalTextBox.TabIndex = 14;
            this.HospitalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(810, 12);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(100, 27);
            this.CloseButton.TabIndex = 15;
            this.CloseButton.Text = "닫기";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("돋움", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(509, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(284, 26);
            this.label3.TabIndex = 18;
            this.label3.Text = "코드의 검사가 있을 시, 라벨을";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.DeleteButton.ForeColor = System.Drawing.Color.White;
            this.DeleteButton.Location = new System.Drawing.Point(810, 102);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(100, 23);
            this.DeleteButton.TabIndex = 19;
            this.DeleteButton.Text = "삭제";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // LabelSettingDrop
            // 
            this.LabelSettingDrop.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LabelSettingDrop.FormattingEnabled = true;
            this.LabelSettingDrop.Items.AddRange(new object[] { "사용하지 않습니다.", "2개 사용합니다.", "3개 사용합니다.", "4개 사용합니다.", "5개 사용합니다.", "6개 사용합니다.", "7개 사용합니다.", "8개 사용합니다.", "9개 사용합니다.", "10개 사용합니다." });
            this.LabelSettingDrop.Location = new System.Drawing.Point(509, 59);
            this.LabelSettingDrop.Name = "LabelSettingDrop";
            this.LabelSettingDrop.Size = new System.Drawing.Size(277, 24);
            this.LabelSettingDrop.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(23, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 19);
            this.label4.TabIndex = 21;
            this.label4.Text = "모든 병원은 0을 입력하세요";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.Navy;
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.SaveButton.ForeColor = System.Drawing.Color.White;
            this.SaveButton.Location = new System.Drawing.Point(810, 56);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(100, 24);
            this.SaveButton.TabIndex = 23;
            this.SaveButton.Text = "저장";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(228, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(275, 19);
            this.label5.TabIndex = 24;
            this.label5.Text = "검사 이름";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(23, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(198, 16);
            this.label6.TabIndex = 25;
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabelSettingDataView
            // 
            this.LabelSettingDataView.FormattingEnabled = true;
            this.LabelSettingDataView.ItemHeight = 12;
            this.LabelSettingDataView.Location = new System.Drawing.Point(12, 131);
            this.LabelSettingDataView.Name = "LabelSettingDataView";
            this.LabelSettingDataView.Size = new System.Drawing.Size(898, 112);
            this.LabelSettingDataView.TabIndex = 26;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(12, 277);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(898, 112);
            this.listBox1.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("돋움", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(12, 248);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(199, 26);
            this.label7.TabIndex = 27;
            this.label7.Text = "개별 세팅";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TestCodeTextBox
            // 
            this.TestCodeTextBox.AutoCompleteCustomSource.AddRange(new string[] { "ACTH (RIA)", "ACTH (ECLIA)", "ACTH-1회", "ACTH-2회", "ACTH-3회", "ACTH-4회", "ACTH-5회", "ACTH-6회", "ACTH-7회", "ACTH-8회", "ACTH-9회", "ADH", "ACTH-10회", "ACTH-11회", "ACTH-12회", "ACTH-13회", "ACTH-14회", "ACTH-15회", "FSH-1회", "FSH-2회", "FSH-3회", "FSH-4회", "FSH-5회", "FSH-6회", "FSH-7회", "FSH-8회", "GH (RIA)", "GH (CLIA)", "Cyclosporine", "Lacosamide", "GH-1회", "GH-2회", "GH-3회", "GH-4회", "GH-5회", "GH-6회", "GH-7회", "GH-8회", "GH-9회", "GH-10회", "GH-11회", "GH-12회", "GH-13회", "GH-14회", "GH-15회", "GH-16회", "FSH (CLIA)", "FSH (ECLIA)", "IGF-2", "LH (CLIA)", "LH (ECLIA)", "LH-1회", "LH-2회", "LH-3회", "LH-4회", "LH-5회", "LH-6회", "LH-7회", "LH-8회", "Prolactin (RIA)", "Prolactin (ECLIA)", "Prolactin (CLIA)", "Prolactin-1회", "Prolactin-2회", "Prolactin-3회", "Prolactin-4회", "Prolactin-5회", "Prolactin-6회", "Prolactin-7회", "Prolactin-8회", "Somatomedin-C (RIA)", "Somatomedin-C (CLIA)", "Free α-Subunit", "Free T3 (RIA)", "Free T3 (ECLIA)", "Free T4 (RIA)", "Free T4 (ECLIA)", "Free thyroxine index", "Neonatal T4", "Neonatal TSH", "Neonatal TSH(추적)", "Reverse T3", "T3 (ECLIA)", "T3-Uptake (RIA)", "T3-Uptake (ECLIA)", "T4 (RIA)", "T4 (ECLIA)", "TBG (RIA)", "Thyroglobulin Ab (RIA)", "Thyroglobulin Ab (ECLIA)", "Thyroglobulin (RIA)", "Thyroglobulin (ECLIA)", "Thyroglobulin (Body fluid)", "TSH (RIA)", "T3 (RIA)", "TSH", "TSH (ECLIA)", "TSH-1회", "TSH-2회", "TSH-3회", "TSH-4회", "TSH-5회", "TSH-6회", "TSH-7회", "TSH-8회", "TSH-R-Ab (RIA)", "TSH-R-Ab(ECLIA)", "17 Hydroxypregnenolone", "17α-OH Progesterone", "dihydrotestosterone", "Estradiol (E2) (CLIA)", "Estradiol (E2) (ECLIA)", "Estradiol (E2) (RIA)", "Free E3", "Estrogen", "Estrone (E1)", "Pregnanediol(Urine)", "Pregnanetriol", "Progesterone (RIA)", "Progesterone (ECLIA)", "Progesterone (CLIA)", "Testosterone (RIA)", "Testosterone (CLIA)", "Testosterone (ECLIA)", "Testosterone, Free", "11-Deoxycorticosterone", "11-Deoxycortisol", "11-OHCS", "17-KS", "17-OHCS", "18-OH Corticosterone", "Corticosterone", "Aldosterone", "Aldosterone(24hr U)", "Aldosterone", "Aldosterone-1회", "Aldosterone-2회", "Aldosterone-3회", "Aldosterone-4회", "Aldosterone-5회", "Aldosterone-6회", "Androstenedione", "AMH", "AMH (Anti Mullerian hormone)", "Androsterone", "Cortisol (RIA)", "Cortisol (Saliva)", "Cortisol", "Cortisol-1회", "Cortisol-2회", "Cortisol-3회", "Cortisol-4회", "Cortisol-5회", "Cortisol-6회", "Cortisol-7회", "Cortisol-8회", "Cortisol-9회", "Cortisol-10회", "Cortisol-11회", "Cortisol-12회", "Cortisol-13회", "Cortisol-14회", "Cortisol-15회", "21-Hydroxylase Antibody", "DHEA", "DHEA", "DHEA-S (RIA)", "DHEA-S (CLIA)", "DHEA-S (ECLIA)", "Free Cortisol (RIA)", "Free Cortisol", "Free Cortisol", "타액호르몬 검사(부신 호르몬)", "타액호르몬 검사(성 호르몬)", "타액호르몬 검사(종합 호르몬)", "5-HIAA 정성", "5-HIAA 정량 (Plasma)", "5-HIAA 정량 (24hr U)", "5-HIAA 정량", "5-HIAA 정량", "Epinephrine", "Epinephrine", "Epinephrine", "Epinephrine", "Epinephrine", "Epinephrine", "Norepinephrine", "Norepinephrine", "Norepinephrine", "Norepinephrine", "Norepinephrine", "Norepinephrine", "Dopamine", "Dopamine", "Dopamine", "Dopamine", "HVA 정량(Plasma)", "HVA 정량(Plasma)", "HVA 정량(LC-MS/MS)", "L-Dopa", "Metanephrine 2F", "Metanephrine", "Normetanephrine", "Metanephrine,Total", "Metanephrines, Plasma", "Metanephrines 2분획(plasma)", "Serotonin(PFP)(LC/MS/MS)", "Serotonin(LC/MS/MS)", "Serotonin(S)", "VMA 정성", "VMA 정량", "VMA 정량", "S-100 Protein Quantification", "C-Peptide (RIA)", "C-Peptide (RIA)", "C-peptide", "C-peptide", "C-peptide", "C-Peptide-1회", "C-Peptide-2회", "C-Peptide-3회", "C-Peptide-4회", "C-Peptide-5회", "C-Peptide-6회", "C-Peptide-7회", "C-Peptide-8회", "C-Peptide-9회", "Gastrin (RIA)", "Gastrin (RIA)", "Gastrin-1회", "Gastrin-2회", "Gastrin-3회", "Gastrin-4회", "Gastrin-5회", "Gastrin-6회", "Gastrin-7회", "Gastrin-8회", "Gastrin", "Pancreatic glucagon", "Insulin (RIA)", "Insulin", "Insulin", "Insulin", "Insulin Fasting", "Insulin-120 min", "Insulin/C-peptide molar ratio", "Insulin Ab", "Insulin-1회", "Insulin-2회", "Insulin-3회", "Insulin-4회", "Insulin-5회", "Insulin-6회", "Insulin-7회", "Insulin-8회", "Insulin-9회", "Insulin Ab(RIA)", "Insulin-10회", "Insulin-11회", "Insulin-12회", "Insulin-13회", "Insulin-14회", "Insulin-15회", "HOMA of insulin resistance", "HOMA of insulin resistance", "HOMA of insulin resistance", "HOMA ß-cell", "Insulin Receptor Ab", "HOMA of insulin resistance", "Phospholipase A2", "Proinsulin", "Proinsulin", "Trypsin", "Tryptase", "VIP", "간세포증식인자(HGF)", "Anti-Trichosporon Asahii", "Ach-r-Binding Ab", "Ach-r-blocking Ab", "C-AMP", "C-AMP", "C-AMP", "ECP", "ECP (Eosinophil Cationic Protein)", "Erythropoietin(EPO)", "Erythropoietin(EPO)", "HBNP", "IGFBP-3 (RIA)", "IGFBP-3 (CLIA)", "Leptin", "Myoglobin", "Myoglobin(RU)", "Myosin light chain 1", "NT-pro BNP", "Renin Activity", "Aldo Renin Ratio", "Aldosterone/Renin Activity Ratio", "Aldosterone/Renin Activity Ratio", "Aldo Renin Ratio", "Renin-1회", "Renin-2회", "Renin-3회", "Renin-4회", "Renin-5회", "Renin-6회", "α-ANP", "AFP", "AFP", "AFP", "AFP-L3(%)", "간세포암 선별검사", "AFP-L3(%)", "β2-Microglobulin", "β2-Microglobulin", "β2-Microglobulin", "β2-Microglobulin(RU)", "β2-Microglobulin(특검)", "Presepsin", "Basic fetoprotein (BFP)", "BCA225", "CA15-3 (RIA)", "CA15-3 (ECLIA)", "CA19-9 (RIA)", "CA19-9 (ECLIA)", "CA19-9 (ECLIA)", "HE4", "ROMA 난소암 위험도", "ROMA 난소암 위험도SET I", "ROMA 난소암 위험도SETⅡ", "ROMA 난소암 위험도SETⅢ", "CA72-4 (RIA)", "CA72-4 (ECLIA)", "CA125 (ECLIA)", "CA 54/61", "CEA (RIA)", "CEA (ECLIA)", "CEA (ECLIA)", "Chromogranin A (CgA)", "CYFRA 21-1 (RIA)", "CYFRA 21-1", "CYFRA 21-1(SCL)", "CYFRA 21-1(Fluid)", "ProGRP", "DUPAN-2", "ProGRP", "Elastase 1", "PAX5 (IHC)(여의도성모)", "Progesterone Receptor(IHC)(여의도)", "ER (IHC)(성모)", "Progesterone Receptor(IHC)(성모)", "ER/PR", "Estrogen Receptor(ER)(IHC)", "ER/PR (여의도성모)", "Estrogen Receptor(ER)(IHC)(여의도성모)", "Progesterone receptor (IHC)(삼성)", "C-MYC (IHC)(삼성)", "C-MYC (IHC)(성모)", "Factor 8 related Ag (IHC)(삼성)", "NUT (IHC)(성모)", "Ferritin (RIA)", "Ferritin (ECLIA)", "Homogentisic acid", "NCC-ST-439", "NSE", "NSE (RIA)", "NSE (ECLIA)", "NSE", "PAP", "PAP", "PIVKA-2", "Prostate Health Index (phi)", "PSA (ECLIA)", "free PSA (RIA)", "Free PSA (ECLIA)", "Free PSA/PSA ratio(ECLIA)", "SCA-1", "SCA-2", "SCA-3", "SCC", "SCC Ag", "SLX", "Span-1", "STN", "Tissue polypeptide Ag(TPA)", "First double Marker", "PAPP-A", "Sequential 1st", "Sequential 1st_NT", "Integrated 1st_PAPP-A", "Integrated 1st_PAPP-A,NT", "First double Marker NT", "First double _MS-hCG", "Integrated_MS-hCG", "First double marker(녹십자)", "PAPP-A(서울대)", "MS-AFP", "MS-hCG", "MS-uE3", "Inhibin-A", "Inhibin B", "Inhibin A", "Triple marker", "Anti Microsome (TPO) Ab (RIA)", "Anti Microsome (TPO) Ab", "Procalcitonin", "Calcitonin (RIA)", "Calcitonin-1회", "Calcitonin-2회", "Calcitonin-3회", "Calcitonin-4회", "Calcitonin-5회", "Calcitonin-6회", "Calcitonin-7회", "Calcitonin-8회", "Calcitonin", "Osteocalcin (RIA)", "Osteocalcin (ECLIA)", "PTH related peptide", "PTH-Intact (RIA)", "PTH-Intact (ECLIA)", "PTH-Intact (ECLIA)", "PTH-Intact (Body fluid)", "hCG (정성)", "β-hCG (RIA)", "β-hCG(ECLIA)", "β-hCG(ECLIA)", "Pepsinogen I", "Pepsinogen II", "Pepsinogen I/II", "Catecholamine 2F", "Catecholamine 2F", "Catecholamine 2F", "Catecholamine 2F(HPLC)", "Catecholamine 3F", "Catecholamine 3F", "Quad Test", "Integrated 2nd (Quad)", "Sequential 2nd (Quad)", "Integrated 2nd(랩지노믹스)", "Sequential 2nd(Quad,녹십자)", "Sequential 2nd(Quad,씨젠)", "Integrated 2nd (Quad,녹십자)", "Integrated 2nd (SCL)", "Integrated 2nd(Quad,이원)", "Integrated 2nd(Quad,씨젠)", "SCA-6", "Sequential 2nd(Quad,SCL)", "Sequential 2nd(Quad,이원)", "Integrated 2nd(SQLab)", "Sequential 2nd(Quad,SQLab)", "Integrated 2nd(신원)-단태아", "Integrated 2nd(신원)-쌍태아", "SCA-7", "SCA-8", "SCA-17", "MSAFP", "AFP (NTD)", "Albumin", "Microalbumin", "Microalbumin(ACR)", "Albumin (CSF)", "Albumin", "Microalbumin/creatinine", "Microalbumin 정량(urine)", "Albumin (Fluid-합포)", "Globulin", "Globulin(Fluid)", "A/G ratio", "A/G ratio (Fluid)", "Total Protein(RU)(특검)", "Protein/creatinine ratio(특검)", "Total Protein", "Total Protein(24hr U)", "Total Protein(CSF)", "Total Protein", "Total Protein(RU)", "Protein/creatinine ratio", "Total Protein (Fluid-합포)", "Protein/creatinine ratio", "Total Bilirubin", "Total Bilirubin", "Direct Bilirubin", "Direct Bilirubin", "Indirect Bilirubin", "Indirect Bilirubin", "Calcium (Ca)", "Calcium (Ca)(24hr U)", "Calcium (Ca)", "Corrected Ca", "Ca/Cr ratio(Urine)", "Calcium excretion", "UCCR", "Ca++", "Ca++", "Chloride(Cl)", "Chloride(Cl)(24hr U)", "Chloride(Cl)", "CO2,Total", "Magnesium (Mg)", "Magnesium (Mg)(24hr U)", "Magnesium (Mg)", "Phosphate(Pi)", "Phosphate(Pi)(24hr U)", "Phosphate(Pi)", "Phosphorus(Pi)(SCL)", "Potassium(K)", "Potassium(K)(24hr U)", "Potassium(K)", "Sodium(Na)", "Sodium(Na)(24hr U)", "Sodium(Na)", "Sodium/Creatinine ratio (Urine)", "Urinary Ca", "ACE", "ACE", "ACP", "ACP", "ADA", "ADA (CSF)", "ADA(Pleural Fluid)", "ADA Fluid (other)", "Aldolase", "ALP", "ALP (Fluid)", "Amylase", "Amylase (RU)", "Amylase (24hr U)", "Amylase", "Pancreatic Amylase", "Pancreatic Amylase(RU)", "Amylase clearance", "Arylsulfatase A", "Arylsulfatase A (MLD) enzyme activity", "Cholinesterase(Pseudo)", "CK(Creatine kinase)", "CK(Creatine kinase)", "CK-MB 정량", "CK-MM", "CK-BB", "AST(GOT)", "AST(GOT)(Fluid)", "AST(GOT)(프라임)", "ALT(GPT)", "ALT(GPT)(Fluid)", "ALT(GPT)(프라임)", "AST(GOT)/ALT(GPT) Ratio", "Guanase", "Placental alkaline phosphatase (PLAP)", "Hexosaminidase A", "LAP", "LDH", "LDH", "Lipase", "Lipase(Fluid)", "Lysozyme", "N-acetyl-β-D-glucosaminidase", "γ- GTP", "SAA (Serum Amyloid A)", "Human Amyloid β", "Citrate", "Citric acid(Citrate,U)", "Citric acid(Citrate,S)", "G-6-PDH", "G-6-PDH", "(1-3)-β-D-Glucan", "Glucose", "Glucose", "Glucose(24hr Urine)", "Glucose", "Glucose-1회", "Glucose tolerance test", "Glucose-Fasting", "Glucose-Fasting", "Glucose-30 MIN", "Glucose-30 MIN", "Glucose-60 MIN", "Glucose-60 MIN", "Glucose-90 MIN", "Glucose-90 MIN", "Glucose-120 MIN", "Glucose-120 MIN", "Glucose-150 MIN", "Glucose-150 MIN", "Glucose-3 hr", "Glucose-3 hr", "Glucose-4 hr", "Glucose-4 hr", "임신성당뇨(100g)부하시험", "임신성당뇨(50+100)부하시험", "임신성당뇨(50g)-60min", "임신성당뇨(50g)-60min", "임신성당뇨(100g)-Fasting", "임신성당뇨(100g)-60min", "임신성당뇨(100g)-120min", "임신성당뇨(100g)-180min", "임신성당뇨(75g)-Fasting", "임신성당뇨(75g)-60min", "임신성당뇨(75g)-120min", "Glycated Albumin", "GA", "G-ALB", "Glycated Albumin", "Hemoglobin A1c", "Lactic Acid(NaF P)", "Lactic Acid(CSF)", "Lactic Acid", "Methanol", "Methylmalonic acid 정량", "Methylmalonic acid 정량", "Methylmalonic acid 정량", "Mucopolysaccharidosis 선별", "Oxalic acid", "Pyruvic Acid", "Pyruvic Acid", "Pyruvic Acid", "Pyruvic Acid", "Sialic acid", "A/CCR", "Serum Amylase", "Urine Amylase(24hr U)", "Serum Creatinine", "Urine Creatinine(24hr U)", "ACCR", "Ammonia (NH3)", "BUN", "BUN(24hr U)", "BUN", "Pre BUN", "Post BUN", "URR(Urea Reduction Ratio)", "Ca x Pi", "Creatine", "Creatine(S)", "Creatine(U)", "Creatinine(24hr U)", "Creatinine(RU)", "Creatinine", "Creatinine (Fluid-합포)", "B/C ratio", "Crea.Clearance Test", "GFR-Cystatin C", "GFR (신사구체여과율)", "GFR", "GFR (CKD-EPI)", "GFR (CKD-EPI Cr-CysC)", "GFR(Cystatin C)", "Uric Acid", "Uric Acid(24hr U)", "Uric Acid", "Apolipoprotein AⅠ", "Apolipoprotein AⅡ", "Apolipoprotein B", "Apo B/Apo A1 ratio", "Apolipoprotein CⅡ", "Apolipoprotein CⅢ", "Apolipoprotein E", "Cardiac Risk Factor", "Total Chol./HDL Chol.(계산법)", "Total Cholesterol", "Total Cholesterol", "small dense LDL cholesterol 분획검사", "Total Cholesterol", "sdLDL cholesterol", "Sterols", "Sterols 3종", "Fatty Acid 5 Fraction(오메가)", "Fatty Acid 5 Fraction(오메가) 용역료", "Fatty Acid 5 Fraction(오메가)", "Free Fatty Acid(NEFA)", "Free Fatty Acid(NEFA)", "HDL Cholesterol", "Non HDL Cholesterol(계산법)", "LDL Cholesterol", "LDL Cholesterol(cal)", "Lipid profile", "LDL Cholesterol(계산법)", "Phospholipid", "Phospholipid(Fluid)", "Triglyceride", "Triglyceride", "Triglyceride(mmol/L)", "TG/HDL ratio", "Paraoxonase (PON1)", "이상지질혈증 profile", "Very long chain fatty acid", "β-Lipoprotein", "Beta-Carotene", "Dihydrotestosterone", "1,25-(OH)2 Vitamin D", "25-OH Vitamin D", "25-OH Vitamin D3 (RIA)", "Carnitine(Vitamin BT)", "L-carnitine (S)", "25-OH Vitamin D,Total", "25-OH Vitamin D2/D3", "Carnitine (vitamin BT)", "Carnitine 2분획", "Folate", "RBC Folate", "Nicotinic acid(Niacin)", "Retinol Binding Protein", "Vitamin A", "MYD88 gene, Mutation", "THRB gene test", "THRB, Family(부분)", "TP53, family(부분)(성모)", "IKZF1 gene test", "Vitamin B1", "Vitamin B2", "Vitamin B6(PLP)", "Vitamin B6 profile", "Vitamin B12", "Vitamin C", "Vitamin C", "Vitamin E", "Vitamin E profile", "Vitamin E Fraction", "Vitamin K Fraction", "β-Carotene", "Tandem mass 이용한 선천성대사이상", "Tandem mass 이용한 선천성대사이상(추적)", "리소좀 축적질환 선별검사", "리소좀 축적질환 선별검사(추적검사)", "17α-OH Progesterone", "17a-OHP(추적)", "Biotinidase enzyme activity", "HVA 정량 (24hr U)", "Phytanic acid", "Succinylacetone", "Coproporphyrin 정성", "Coproporphyrin 정량", "Porphobilinogen 정성", "Porphobilinogen 정량", "Porphobilinogen 정량", "Total Porphyrin 정성", "Uroporphyrin 정성", "Uroporphyrin 정량", "Zinc Protoporphyrin(ZPP)", "Zinc Protoporphyrin(ZPP)(특검)", "Zinc Transporter 8 (ZnT8) Antibody", "δ-ALA", "δ-ALA", "δ-ALA(특검)", "Perampanel", "Mercury(Hg)", "Perampanel (serum level)", "Vanadium(V)(특검)", "Methylethylketone(MEK)(특검)", "Methyl ethyl ketone(특검)", "Methyl isobutyl ketone(특검)", "Alcohol (Ethanol)", "Alcohol", "Alcohol (RU)", "Auto hemolysis test", "Bile acid", "Bile acid", "Bone ALP", "Collagen Type Ⅳ", "Cotinine 정성", "Nicotine Metabolite(S)", "Nicotine Metabolite(U)", "Ham test", "Homocysteine", "Homocysteine", "Homocysteine (RU)", "Homocysteine", "Hyaluronic Acid", "Hydroxyproline Total", "1CTP(type 1 collagen)", "Indocyanine Green정체율", "Indocyanine Green(R15)", "Ketone body (S)", "Ketone body (RU)", "Ketone Body 3F (Arterial)", "Ketone Body 3F (Venous)", "Ketone Body 3분획", "Ketone Body 3분획", "Ketone Body 3분획", "MA+PGA(특검)", "Glutamic acid", "Methylhippuric acid(특검)", "N-acetyl aspartic acid", "Neopterin", "Neopterin", "Neopterin/Biopterin", "N-Methylformamide(특검)", "NTx", "Organic Acid", "Organic Acid", "OAP Panel 1", "OAP Panel 2", "OAP Panel 3", "Organic Acid analysis", "Organic Acid analysis", "Organic acid profile", "Adrenal Stress profile", "Orotic acid", "Osmolality", "Osmolality(24hr U)", "Osmolality(RU)", "Osmolality(S)-1회", "Osmolality(S)-2회", "Osmolality(S)-3회", "Osmolality(S)-4회", "Osmolality(S)-5회", "Osmotic fragility", "Osmolality(S)-6회", "Osmolality(S)-7회", "Osmolality(S)-8회", "Osmolality(S)-9회", "Osmolality(S)-10회", "Osmolality(S)-11회", "Osmolality(S)-12회", "Osmolality(S)-13회", "Osmolality(S)-14회", "Paraquat (gramoxone)", "Paraquat", "Primidone(Mysoline)", "Procollagen Ⅲ peptide", "Deoxypyridinoline(DPD)", "Semen Analysis", "Semen Analysis", "SHBG (RIA)", "SHBG (ECLIA)", "Free testosterone index", "Stone Analysis 정성", "Stone analysis (physical)", "Stone Analysis(physical)", "Surfactant protein-A(SP-A)", "2,5-Hexanedione(특검)", "TCA_TCE(특검)", "TCA_1,1,1-TCE(특검)", "TCA_PCE(특검)", "Total Trichloroethanol(특검)", "1,2-Dichloropropane(1,2-DCP)(특검)", "Troponin I", "Troponin T", "Soluble ST2", "γ-Aminobutylic acid(GABA)", "Gabapentin", "Gabapentin", "투석용수 미생물배양검사(HDF)", "모발분석(병원급)", "모발분석(의원급)", "모발분석(단체검진용)", "투석용수 내독소검사", "모발분석(메디넥스)", "모발 중금속 및 미네랄 검사", "Acetone 정량", "Acetone (특검)", "모발분석(마이엠티)", "Iodine (RU)", "Iodine (24hr U)", "Acetone 정량", "혈중 중금속 및 미네랄 13종", "Aluminium(Al)", "Aluminium(Al)", "Aluminium(Al)", "Arsenic(As)", "Arsenic(As)", "Arsenic(As)", "Arsenic(As)(특검)", "(특검)비소 분획검사(RU)", "Cadmium(Cd)", "Cadmium(Cd)", "Cadmium(Cd)", "Cadmium(Cd)(특검)", "Cadmium (Cd)(특검)", "Chromium(Cr)", "Chromium(Cr)", "Chromium(Cr)", "혈중 중금속 및 미네랄 13종 검사", "혈액 중금속 및 미네랄 검사", "소변 중금속 및 미네랄 검사", "혈중 중금속 5종", "소변 중금속 5종", "Cobalt(Co)", "Cobalt(Co)", "Cobalt(Co)", "Copper(Cu)", "Copper(Cu)", "Copper(Cu)", "Iron (Fe)", "Indium(In)(특검)", "Lead(Pb)", "Lead(Pb)", "Lead(Pb)", "Lead(Pb)(특검)", "Lead(Pb)(특검)", "Lead (Pb)", "Lithium(Li)", "Lithium(Li)", "Manganese(Mn)", "Manganese(Mn)", "Manganese(Mn)", "Molybdenum(Mo)", "Mercury(Hg)", "Mercury(Hg)", "Mercury(Hg)", "Mercury(Hg)(특검)", "Mercury(Hg)(특검)", "Nickel(Ni)", "Nickel(Ni)", "Nickel(Ni)(특검)", "Phenol(특검)", "Phenol", "o-cresol(특검)", "Selenium", "Selenium", "Selenium", "Silica", "TIBC", "UIBC", "Zinc(Zn)", "Zinc(Zn)", "Lipoprotein(a)", "Sucrose hemolysis", "갈락토스혈증", "갈락토스혈증(추적)", "Anion GAP", "Fat 정성 검사", "Cystatin C", "Galactose-1-Phosphate", "G-1-P Uridyltransferase", "Galactokinase", "UDP-Galactose-4-Epimerase", "Galactosemia 확진검사(3종)", "Galactosemia 확진검사(4종)", "P1NP", "CTx", "Amino acid Profile", "Amino Acid 분석 [P, LC/MS-MS]", "Amino Acid 분석 [U, LC/MS-MS]", "Amino Acid 분석 [CSF, LC/MS-MS]", "Surfactant protein-D(SP-D)", "KL-6", "선천성 대사이상 선별검사", "선천성 대사이상 선별검사(추적검사)", "신생아대사(선별)&유전검사 SET1", "신생아대사(선별)&유전검사 SET2", "선천성대사이상&리소좀축적질환선별검사", "β-Galactosidase", "신생아대사(선별)&유전검사 SET3", "선천성대사이상검사 (선별)", "선천성대사이상검사 (확인)", "선천성대사이상&리소좀축적질환선별검사(추적)", "Iodine", "Coenzyme Q10", "Biotinidase", "β-Glucosidase (Gaucher) enzyme activity", "β-Glucosidase(Gaucher\'s)", "GBA sequencing(Gaucher\'s)", "항ENA 및 항DNA 항체 다종검사", "Galactocerebrosidase(Krabbe)", "α-Galactosidase (Fabry)", "Fabry Screening", "Screening 6종 Screening", "α-Galactosidase A (Fabry)", "Lyso-Gb3", "α-Galactosidase", "GLA gene", "Gb-3 (SCL)", "Lyso-Gb3+Gb-3", "α-L-iduronidase", "IDUA gene", "HER2 단백질", "MYH7 gene mutation", "MPS-I/IIscreening(LSD 6종+MPS-II screening)", "FGF23", "VEGF", "Acylcarnitine 정량", "Lyso-Gb1", "Calprotectin", "Calprotectin (Serum)", "활성산소&항산화력 검사", "TAS&TOS test (항산화력&활성산소)", "혈청 간섬유화 검사", "Urinary bromide (24hr U)", "CD16+56 (NK cell)", "Lymphocyte subset 2종 Ⅰ", "Lymphocyte subset 2종 Ⅱ", "Lymphocyte subset 2종 Ⅲ", "Lymphocyte subset 2종 Ⅳ", "Lymphocyte subset 3종 Ⅰ", "Lymphocyte subset 3종 Ⅱ", "Lymphocyte subset 4종 Ⅰ", "Lymphocyte subset 4종 Ⅱ", "Lymphocyte subset 5종", "Lymphocyte subset 2종Ⅰ(count)", "Lymphocyte subset 2종 Ⅱ(count)", "Lymphocyte subset 2종 Ⅲ(count)", "Lymphocyte subset 2종 Ⅳ(count)", "Lymphocyte subset 3종 Ⅰ(count)", "Lymphocyte subset 3종 Ⅱ(count)", "Lymphocyte subset 4종 Ⅰ(count)", "Lymphocyte subset 4종 Ⅱ(count)", "Lymphocyte subset 5종(count)", "Lymphocyte subset 3종 Ⅳ", "Lymphocyte subset 4종", "Lymphocyte subset 3종", "SISH_Her2 (서울대)", "25(OH) Vitamin D2/D3", "HMGCR Ab IgG", "PD-L1 IHC 22C3 pharmDx (두경부암)", "PLA2R (IHC)(삼성)", "Arginase 1 (IHC)(삼성)", "ATRX (IHC)(삼성)", "MAP2(IHC)(삼성)", "BRG1(IHC)(삼성)", "OCT-2(IHC)", "PTEN (IHC)(삼성)", "1,5-Anhydroglucitol", "C1 inactivator", "C1 inactivator", "C3", "C4", "Ceruloplasmin", "Ceruloplasmin", "Cryoglobulin 정성", "Cryoglobulin 정성", "Haptoglobin", "Haptoglobin", "IgA", "IgA", "IgD", "IgG", "IgG", "Immunoglobulin G Index", "Immunoglobulin G Index", "Subclass IgGⅠ", "Subclass IgGⅠ", "Subclass IgGⅡ", "Subclass IgG II", "Subclass IgGⅢ", "Subclass IgG III", "Subclass IgGⅣ", "Subclass IgG IV", "IgM", "IgM", "Microalbumin(RIA)(8hr)", "Microalbumin(RIA)", "Microalbumin(RIA)(24hr)", "Oligoclonal band", "Oligoclonal band (급여)", "Oligoclonal band (비급여)", "Prealbumin", "Selectivity Index", "Transferrin", "Transferrin saturation", "Transferrin saturation", "α1-Acidglycoprotein", "α1-Antitrypsin", "α1-Antitrypsin(serum)", "α1-Antitrypsin", "α1-Antitrypsin clearance", "α1-Microglobulin", "α1-Microglobulin", "α2-Macroglobulin", "Apt test", "Apt test", "Carboxy Hemoglobin", "Carboxy Hemoglobin(특검)", "Carboxy Hb", "Met Hb(특검)", "Fetal hemoglobin", "Fructosamine", "Hemoglobin E.P", "Co-oximeter", "Met Hemoglobin", "Plasma Hb", "Plasma Hb(동물검체)", "ALP Isoenzyme", "Amylase Isoenzyme", "Amylase Isoenzyme", "CK Isoenzyme", "CK Isoenzyme", "Immuno Fixation E.P (Serum)", "Immuno Fixation E.P", "Immuno Fixation E.P(24h urine)", "Immuno Fixation E.P IgD,IgE(S)", "Immuno Fixation E.P IgD,IgE(U)", "IFEP + PEP (Serum)", "IFEP + PEP (24h urine)", "IFEP + PEP (Random Urine)", "LDH Isoenzyme", "LDH Isoenzyme", "Lipoprotein E.P", "Lipoprotein E.P", "Lipoprotein lipase", "Protein E.P(Serum)", "Protein E.P(24h urine)", "Protein E.P(Random urine)", "Protein E.P(CSF)", "Immunoglobulin E.P (Serum)", "Immunoglobulin E.P (U)", "Immunoglobulin E.P (24U)", "CDT", "Liver bx (Level C 1-9개)(은평성모)", "Actin(IHC)(은평성모)", "AFP(IHC)(은평성모)", "Bcl2(IHC)(은평성모)", "Bcl6(IHC)(은평성모)", "C4d(IHC)(은평성모)", "CD10(IHC)(은평성모)", "CD117(C-kit)(IHC)(은평성모)", "CD20(IHC)(은평성모)", "CD23(IHC)(은평성모)", "CD3(IHC)(은평성모)", "CD30(IHC)(은평성모)", "CD31(IHC)(은평성모)", "CD34(IHC)(은평성모)", "CD38(IHC)(은평성모)", "CD4(IHC)(은평성모)", "CD45RB(LCA)(IHC)(은평성모)", "CD5(IHC)(은평성모)", "CD56a(IHC)(은평성모)", "CD68(IHC)(은평성모)", "CD8(IHC)(은평성모)", "CDX2(IHC)(은평성모)", "CK19(IHC)(은평성모)", "CK20(IHC)(은평성모)", "CK7(IHC)(은평성모)", "CMV(IHC)(은평성모)", "Cyclin D1(IHC)(은평성모)", "Cytokeratin-AE1/AE3(IHC)(은평성모)", "Desmin(IHC)(은평성모)", "Estrogen Receptor(IHC)(은평성모)", "GATA3(IHC)(은평성모)", "Glutamine synthetase(IHC)(은평성모)", "Glypican3(IHC)(은평성모)", "HSA(IHC)(은평성모)", "Ki-67(IHC)(은평성모)", "Myeloperoxidase(MPO)(IHC)(은평성모)", "MUM1(IHC)(은평성모)", "P40(IHC)(은평성모)", "PAX8(IHC)(은평성모)", "PD-1(IHC)(은평성모)", "PSA(IHC)(은평성모)", "S-100(IHC)(은평성모)", "TdT(IHC)(은평성모)", "TTF-1(IHC)(은평성모)", "WT-1(IHC)(은평성모)", "Masson Trichrome(은평성모)", "Reticulin(은평성모)", "EBV in situ(은평성모)", "Synaptophysin(IHC)(은평성모)", "Chromogranin(IHC)(은평성모)", "IgG(IHC)(은평성모)", "IgG4(IHC)(은평성모)", "DOG-1(IHC)(은평성모)", "PD-L1(22C3) Level 1(IHC)(은평성모)", "Amyloid A(IHC)(은평성모)", "CK8/18(IHC)(은평성모)", "ERG (IHC)(성모)", "TCRrd-1 PE-Cy7", "ROR1 PE", "CD43", "CD79b", "CD23", "헬로진_일반질환_27종(테라젠)", "헬로진_플래티넘 라이트_38종(테라젠)", "헬로진_플래티넘_48종(테라젠)", "헬로진_노블_92종(테라젠)", "헬로진_맞춤형 남성 암 5종(테라젠)", "헬로진_맞춤형 여성 암 5종(테라젠)", "헬로진_맞춤형 일반질환 5종(테라젠)", "헬로진_맞춤형 뇌심혈관질환 5종(테라젠)", "헬로진_맞춤형 부인과질환 5종(테라젠)", "헬로진_맞춤형 뇌신경질환 5종(테라젠)", "헬로진_암_11종(테라젠)", "헬로진- I(테라젠)", "장내세균검사", "헬로진_맞춤형 남성 암 6종(테라젠)", "헬로진_맞춤형 여성 암 6종(테라젠)", "장내세균검사(메디넥스)", "헬로진_용역료", "진스타일_뷰티케어(테라젠)", "Organic acids profile", "유투바이옴", "얼리텍 대장암검사(검진)", "헬로진 맞춤형 남성암 7종(테라젠)", "헬로진 맞춤형 여성암 8종(테라젠)", "헬로진_맞춤형 일반질환 7종(테라젠)", "마이크로브앤미 코어(장내세균)", "더바이옴프로(장내세균)", "PGx-NP", "CYP2D6 Gene", "CYP2C19 Gene", "장내세균검사(테라젠 바이오)", "PGx-Primium+", "헬로진 한국대표암 5종(테라젠)", "헬로진 남성암 5종(테라젠)", "헬로진 여성암 5종(테라젠)", "헬로진 호흡기 5종(테라젠)", "헬로진 내분비 5종(테라젠)", "헬로진 뇌신경 5종(테라젠)", "헬로진 심혈관 5종(테라젠)", "헬로진 소화기 5종(테라젠)", "헬로진 근골격 5종(테라젠)", "헬로진 안질환 5종(테라젠)", "헬로진 남성질환 5종(테라젠)", "헬로진 여성질환 5종(테라젠)", "헬로진 소아질환 5종(테라젠)", "헬로진 마인드헬스 5종(테라젠)", "헬로진 면역플러스 5종(테라젠)", "헬로진 굿슬립 5종(테라젠)", "헬로진 스탠다드 암I (10종)(테라젠)", "헬로진 스탠다드 암II (12종)(테라젠)", "헬로진 스탠다드 일반질환I (테라젠)", "헬로진 스탠다드 일반질환II (테라젠)", "헬로진 스탠다드 암 Total(I,II) (테라젠)", "헬로진 스탠다드 일반질환 Total (테라젠)", "헬로진 플래티넘 라이트(81종)(테라젠)", "헬로진 플래티넘(91종)(테라젠)", "헬로진 노블(135종)(테라젠)", "얼리텍 대장암검사(검진)", "진스타일 다이렉트 종합", "진스타일 다이렉트 아웃핏뷰티", "진스타일 다이렉트 이너헬스", "얼리텍 대장암검사(검진센터)", "얼리텍 대장암검사(처방)", "헬로진 플래티넘 라이트(81종)(일반)", "헬로진 플래티넘(91종)(일반)(테라젠)", "헬로진 노블(135종)(일반)(테라젠)", "얼리텍 대장암검사(처방)", "진스타일 웰니스(69종)", "진스타일 헬스&뉴트리션(38종)", "진스타일 뷰티&피트니스(30종)", "진스타일 다이어트(28종)", "PGx-Primium", "CYP2C9 Gene", "VKORC1 Gene", "TPMT Gene", "NUDT15 Gene", "UGT1A1 Gene", "HLA-B*58:01", "M-Check 여성암 12종", "M-Check 남성암 11종", "M-Check 남성암 5종", "M-Check 남성암 10종", "M-Check 여성암 5종", "M-Check 여성암 10종", "M-Check 여성암 14종", "M-Check 암,심혈관 6종", "M-Check 9종", "M-Check 3종", "M-Check 4종", "M-Check 7종", "M-Check 8종", "M-Check 3종 (목포한국병원)", "M-Check 4종 (목포한국병원)", "M-Check 5종 (목포한국병원)", "M-Check 6종 (목포한국병원)", "M-Check 7종 (목포한국병원)", "M-Check 48종", "M-Check 52종 (여성)", "M-Check 5종", "M-Check 6종", "M-Check 30종", "M-Check 8종 (여수한국병원)", "M-Check 5종 (여수한국병원)", "M-Check 3종 (여수한국병원)", "M-Check 공통17종", "M-Check 남성암 22종", "M-Check 여성암 24종", "M-Check 12종", "M-Check 2종", "텔로체크(운송료)", "M-Check 10종", "텔로체크", "M-Check 13종", "M-Check 25종", "M-Check 1종(목포시의료원)", "마이지놈스토리 10종 (남)", "마이지놈스토리 10종 (여)", "마이지놈스토리 34종 (남)", "마이지놈스토리 35종 (여)", "마이지놈스토리 6종", "마이지놈스토리 7종", "지놈체크 K(M 확진용)", "지놈체크 MV2", "지놈체크 M", "지놈체크 A", "지놈체크 G 플러스 + 윌슨", "지놈체크 G 플러스", "지놈체크 G", "지놈체크 G + 윌슨", "마이지놈스토리 12종", "마이지놈스토리 13종(여)", "지놈체크 CMA", "약물유전체검사", "지역채혈료", "휘트니스 혈액검사3", "장기이식 검체관리비", "분당서울대 지역채혈", "보라매병원 지역채혈", "국립암센터 지역채혈", "Acetylcholinesterase", "AFAFP", "AFAFP", "AFAFP+AChE", "AChE+Chromosome", "AFAFP+Chromosome", "Amino&AFP&Acetylcholinesterase(3종)", "Chromosome Analysis(PB)", "Chromosome Analysis(AF)", "Chromosome Analysis(BM)", "Chromosome Analysis", "Chromosome Analysis(CB)", "Chromosome Analysis(Stem)", "Chromosome Analysis(Stem)국책", "Chromosome analysis(Leukemia)", "Chromosome test (아산)", "Chromosome test(PB)", "Chromosome Analysis(BM)", "SLC2A1 gene mutation", "Chromosome (AF)", "Chromosome BM", "Chromosome analysis(Tissue)(성모)", "Chromosome(Long Term)", "DES(Diagnostic Exome Sequencing Test)", "Chromosome(Direct+Long)", "Chromosome(Direct)", "CMA-H", "CMA-R", "염색체 마이크로어레이검사(CMA)", "Chromosome(High Resolution)", "Chromosome Microarray, familly", "Prenatal Chromosome Microarray", "Chromosome Microarray", "Chromosomal microarray(양수)", "친자확인(부or모+자)검사", "친자확인 검사대상자 1인추가", "개인식별검사", "친자확인 출장비", "이산가족 유전자검사 용역료", "ABO genotyping", "ABO genotype", "ABO genotyping(서울성모)", "ABO genotyping", "MNS, major genotyping", "FGFR3 full sequencing", "ACTA2 Gene, Mutation", "RUNX1::RUNX1T1(AML1::ETO) 정성검사", "RUNX1::RUNX1T1(AML1::ETO) 정량검사", "AML1/ETO (성모)", "APOE genotype", "EGFR gene mutation", "자궁내막암 POLE 유전자 돌연변이 검사", "지놈헬스 여성암(5A)", "방사선피폭(안정형_작업자)", "Familial mutation(녹십자)", "캔서 리스크스크린(여)(녹십자)", "뇌졸중 리스크스크린 (녹십자)", "고지혈증 리스크스크린 (녹십자)", "캔서 리스크스크린(남)(녹십자)", "환경성 독성물질Ⅰ(유해금속류 및 코티닌)", "내분비 교란물질Ⅰ(비스페놀 및 페놀류)", "내분비 교란물질Ⅱ(과불화화합물)", "내분비 교란물질Ⅲ (프탈레이트류)", "상동 재조합 결핍 검사(그린플랜 HRD)", "알코올 리스크 스크린 (녹십자)", "BRCA1/2 gene mutation", "BRCA1 gene mutation", "BRCA1 가족검사", "BRCA2 gene mutation", "BRCA2 가족검사", "BCR::ABL1 (major) 정성검사", "Major BCR-ABL1 Fusion RT PCR(성모)", "Minor BCR-ABL1 Fusion RT PCR(성모)", "Bacteria, rDNA identification (성모)", "BCR::ABL1 (minor) 정성검사", "NDP gene mutation (Norrie disease)", "EDA gene mutation (삼성)", "CHD7 gene mutation (삼성)", "RS1 gene mutation (삼성)", "DMD/BMD", "DMD/BMD exon deletion/duplication", "Hereditary multiple osteochondromas, EXT1", "가족검사 DMD(sequencing)", "DMD gene mutation (sequencing)", "DMD/BMD exon deletion test", "DMD/BMD", "DMD/BMD Deletion", "FISH(18) Chromosome", "FISH(18)", "Hereditary multiple osteochondromas, EXT2", "MATN3 gene, Mutation (Epiphyseal dysplasia)", "FISH(21) Chromosome", "FISH(21)", "FISH(13) Chromosome", "FISH(13)", "Fragile X Syndrome Screening Test", "Fragile X", "HLA-A,B 조혈모이식1차", "HLA-C,DR 조혈모이식2차", "HLA-A,B,C,DR 조혈모 수여", "HLA-A,B,C,DR,DQ 조혈모 수여", "HLA-A,B,C 조혈모 이식", "HLA-DR 조혈모 이식", "HLA-DQ 조혈모 이식", "HLA-A Typing (High)", "HLA-A 조혈모 이식", "HLA-B 조혈모 이식", "HLA-C 조혈모 이식", "HLA-A Typing (High) KONOS", "HLA-A Typing (Low)", "HLA-B Typing (High)", "HLA-B Typing (High) KONOS", "HLA-B Typing (Low)", "HLA-C Typing (High)", "HLA-C Typing (Low)", "HLA-B27", "HLA-B27 PCR(BSH Lab)", "HLA-ABC(high resolution)(BSH Lab)", "HLA-DR(high resolution)(BSH Lab)", "HLA-DQ(high resolution)(BSH Lab)", "HLA-A(high resolution)(BSH Lab)", "HLA-B(high resolution)(BSH Lab)", "HLA-C(high resolution)(BSH Lab)", "HLA-ABC(high)(비혈연기증자)(BSH Lab)", "HLA-DR(high)(비혈연기증자)(BSH Lab)", "HLA-B51", "HLA-DQ(high(비혈연기증자)(BSH Lab)", "HLA-B5801 genotyping", "HLA-DQB1 (Low)", "HLA-DQB1 Typing (High)", "HLA-DQB1 Typing (High)", "HLA-DQB1 Typing (Low)", "HLA-DR Typing (Low)", "HLA-DR Typing (High)", "HLA-DR Typing(High) KONOS", "BRCA1 gene, del/dup", "BRCA2 gene, del/dup", "유전성 유전질환 확인검사(부분,비급여)", "PRA Screening I", "PRA Screening II", "BRCA1 genetic Test", "BRCA2 genetic Test", "CALR Gene", "BRCA 고위험군 유전자돌연변이 검사", "유전성유전질환 Family(급여)", "유전성유전질환 Family(비급여)", "CSF3R gene mutation", "Huntington\'s disease", "TCOF1 gene mutaion (아산)", "HD gene mutation (Huntington disease)(삼성)", "TCOF1 gene mutation (삼성)", "Free Lambda light chain", "Free Lambda light chain", "SOX9 gene mutation (삼성)", "NSD1 gene mutation (삼성)", "ATP7A gene mutation (Menkes disease)", "CFH gene mutation", "BRAF유전자, 돌연변이 (여의도성모)", "CSF1R gene mutation(HDLS) (삼성)", "Acethylcholine receptor Ab", "FUS gene, mutation", "PARK2 gene mutation(성모)", "STK11 gene, Mutation", "PKD 1 gene test", "LHON 3460,4171,11778,14484", "LHON 3460,11778,14484,15257", "TSC1 gene, Mutation", "TSC2 gene, Mutation", "PTEN gene, mutation(성모)", "PRRT2 gene mutation", "RHD genotype identification [sequencing]", "RHD genotype screening [PCR]", "DICER1 gene, mutation (DICER1-related disorders)", "NPC1 gene mutation", "NPC2 gene mutation", "MELAS, MT-TL1(Leigh disease)", "MELAS, MT-TL1 sequencing", "beta-Thalassemia mutation(성모)", "COL1A1 gene, mutation", "PANK2 gene mutation(성모)", "DMD gene, mutation(성모)", "CACNA1A gene,mutation (성모)", "CHD7 gene, mutation(성모)", "RNF213(p.R4810K) mutation", "AZA Genotyping", "FANCA gene, Mutation", "MLL2 gene, Mutation", "FMC7", "SALL1 gene, mutation", "CFTR gene, Cystic fibrosis", "미세결실증후군 MLPA검사", "DMPK gene mutation", "GNE gene mutation", "DYSF gene mutation", "CAPN3 gene mutation", "STAT3 gene mutation (Hyper IgE Syndrome)", "ABCB11 gene mutation", "PRA 선별(Class I)(녹십자)", "PRA 선별(Class II)(녹십자)", "PRA 동정(Class I)(녹십자)", "PRA 동정(Class II)(녹십자)", "PML::RARA 정성검사", "PML::RARA 정량검사", "PML-RARa RQ-PCR (성모)", "PML-RARa PCR", "HBA1 gene mutation", "HBA2 gene mutation", "HBA1/HBA2 gene mutation", "Chimerism (pre-BMT)", "pre-BMT (성모)", "pre-BMT (삼성)", "FISH-Myeloma 종합판독", "Chimerism (post-BMT)(BM)", "Chimerism (post-BMT)(Blood)", "post-BMT (삼성)", "post-BMT (성모)", "FISH_Prader-Willi syndrome", "FISH_Prader-Willi/Angelman syndrome", "FISH_Prader-Willi/Angelman syndrome", "FISH_Rb gene", "FISH_Rb gene", "DEK-NUP214 Fusion gene(성모)", "FISH_Prader-Willi/Angelman&Culture", "JAK2 Gene (FISH)(성모)", "Eosinophilia panel A", "Eosinophilia panel B", "H19/KCNQ1OT1", "Y-Chromosome(SRY gene)", "FISH_SRY", "ABCC8 gene, mutation (Familial hyperinsulinism)", "CRLF2 Gene (FISH)(성모)", "ABL1 Gene (FISH)(성모)", "FISH_ETV6::RUNX1 Fusion Gene (성모)", "Chromosome 7q (FISH)(성모)", "FISH_IGH Gene (성모)", "HBB gene, deletion/duplication(MLPA)", "β-Thalassemia", "β-Thalassemia", "HBB gene mutation (β-Thalassemia) [sequencing]", "HBA1/HBA2 gene mutation", "HBA1/HBA2 gene mutation(MLPA)", "Thalassemia battery", "CREBBP gene, mutation", "NTRK1 gene, mutation", "PEX1 gene, mutation", "FKTN gene, mutation", "Prader-Willi/Angelman syndrom PCR", "Rett Syndrome,MECP2 [MLPA]", "IgH gene rearrangement (아산)", "IgH gene rearrangement (삼성)", "IGK gene rearrangement", "IGL gene rearrangement", "IGH gene rearrangement", "IGH/IGK Gene Rearrangement Analysis", "TRB/TRG Gene Rearrangement Analysis", "TCR γ gene rearrangement", "surface Ig-Kappa light chain", "surface Ig-Lambda light chain", "Free Lambda-Free Kappa", "Free Lambda-Free Kappa(U)", "Free Kappa-Free Lambda", "Free Kappa-Free Lambda(U)", "Free Kappa light chain", "Free Kappa light chain(U)", "Free Lambda light chain", "Free Lambda light chain(U)", "Free Kappa/Free Lambda ratio", "Free Kappa/Free Lambda ratio", "Free Kappa/Free Lambda ratio", "Free Kappa/Free Lambda ratio(U)", "TCR γ gene rearrangement", "TCR γ gene rearrangement", "TCR β gene rearrangement", "TCR β gene rearrangement", "TCR γ gene rearrangement", "TCR δ gene rearrangement", "TCR δ gene rearrangement", "TCR β gene rearrangement", "Free Kappa light chain", "Free Kappa light chain", "Anti-ENA/DNA [multiplex]", "CD3(T-cell)(BAL)", "CD3 (T3)", "CD4 (T helper)", "CD4(T-helper)(BAL)", "CD4(성모)", "CD4 (BAL fluid)", "CD5(성모)", "CD19(성모)", "CD20(성모)", "CD25(성모)", "CD19 (B-cell)", "CD8(성모)", "CD19 B CELL", "CD38(성모)", "CD56(성모)", "CD138", "CD138(삼성)", "CD1a(성모)", "CD99(성모)", "CD99 (IHC)", "CD33(성모)", "CD34(성모)", "CD117(성모)", "TDT(성모)", "CD8 (T suppressor)", "CD8(T-suppressor)(BAL)", "CD8 (BAL fluid)", "CD4/CD8 ratio (BAL)", "CD3(삼성)", "CD4(삼성)", "CD5(삼성)", "CD16+CD56(NK-cell)[BAL]", "CD19 (B-cell) [BAL]", "CD19", "cCD22", "CD38", "CD20", "FISH_IGH-BCL2 Gene (성모)", "FISH_SS18(SYT) rearrangement (성모)", "FISH_CDKN2A/CEP9", "CD103", "CD103", "CD7(성모)", "CD11c", "FMC7", "HLA-DR(B&MONO)(성모)", "CD13(성모)", "cy-MPO(성모)", "cy-CD3(성모)", "cy-CD79a(성모)", "CD16(성모)", "B-ALL MRD(성모)", "ETP-ALL MRD(성모)", "Myeloma(유세포분석법)(성모)", "IGH Gene Rearrangement Analysis (NGS) (성모)", "CD34", "CD40/CD154(CD40L) Profile", "CD45(삼성)", "PNH study", "Perforin profile, FCM", "Lymphocyte subset 4종", "Lymphocyte subset 6종", "Lymphocyte subset 5종(count포함)", "MRD (Minimal residual disease)", "Leukemia/Lymphoma Immunophenotyping", "CD19+CD20", "Hemavision, Acute leukemia gene rearrangement prof", "FISH_BCR-ABL1 Fusion Gene", "FISH_BCR::ABL1 Fusion Gene", "PNH test", "PNH test", "FISH_HER2", "SISH_Her-2/neu(breast,gastric)", "SISH_Her-2/neu(breast,gastric)", "FISH_Her2/neu (여의도성모)", "FISH C-MET (여의도성모)", "FISH_ROS1 (여의도성모)", "PD-L1 22C3 pharmDx (여의도성모)", "ROS1 (IHC)(삼성)", "STAT6(IHC)(삼성)", "TFEB (IHC)", "GH(IHC)(삼성)", "alpha-1-anti Chymotrypsin(IHC)(삼성)", "CD138 (IHC)(여의도성모)", "CD117(c-kit) (IHC)", "CD117(c-kit)(IHC)(여의도성모)", "TPIT(TBX19)(IHC)", "PIT-1(IHC)", "SF-1 (IHC)", "somatostatin (IHC)", "CD117", "Myeloma immunophenotyping(8종)", "MM MRD", "ALL MRD (8종)", "CD8(성모)", "Acute Leukemia panel", "Chronic Leukemia panel", "RUNXI-RUNX1T1 Fusion", "CBFB-MYH11 Fusion RT PCR", "FLT3, TKD mutation", "FLT3-ITD 정량", "FLT3  ITD/TKD mutation", "PRA 선별(Class I)(이원)", "PRA 선별(Class II)(이원)", "NK 세포 활성도 검사", "NK 세포 활성도 검사", "NK 세포 활성도 검사", "HLA항체 동정검사-Class I", "HLA항체 동정검사-Class II", "HLA 단일항원 동정검사 I", "HLA 단일항원 동정검사 II", "NK 세포 활성도 검사", "Wilson disease, ATP7B gene", "Wilson disease, ATP7B whole", "Wilson disease, ATP7B", "FISH(21)&Culture", "FISH_Williams syndrome", "FISH_Williams syndrome", "FISH(13)&Culture", "PRA 동정(Class I)(이원)", "PRA 동정(Class II)(이원)", "FISH(18)&Culture", "HLA-A Typing (Low)", "HLA-A Typing (Low)", "HLA-B Typing (Low)", "HLA-B Typing (Low)", "HLA-C Typing (Low)", "HLA-C Typing (Low)", "HLA항체 단일항원 동정검사 Class I", "HLA항체 단일항원 동정검사 Class II", "Organic acids profile", "Organic acids profile 51종", "HLA-DQ Typing (Low)", "HLA-DQ Typing (Low)", "HLA-DR Typing (Low)", "HLA-DR Typing (Low)", "C1q Binding HLA Ab (SA-ClassI)", "C1q Binding HLA Ab (SA-ClassII)", "APC gene mutation analysis", "PHOX2B gene mutation", "MUTYH gene test", "MLH1 gene mutation analysis", "hMLH1 mutation identification test", "MSH2 gene mutation", "hMSH2 mutation identification test", "Hemochromatosis(C282Y/H63D)", "Hemochromatosis, HFE gene mutation", "Desmoglein 1,3 IgG Ab", "FISH_Myeloma Profile", "FISH_CATCH 22", "FISH_CATCH 22", "FISH_CATCH 22&Culture", "FISH_del(13q14.3)", "FISH_Centromere 4/10/17 (삼성)", "CBFB-MYH11 Fusion Gene (성모)", "FISH_CBFB::MYH11 Fusion Gene", "MYH9 gene mutation (MYH9-related disorder)", "FISH_Chromosome 13q (성모)", "FISH_IGH-CCND1 Fusion Gene (성모)", "FISH_IGH-FGFR3 Fusion Gene (성모)", "FISH_IGH-MAF Fusion Gene (성모)", "FISH_Chromosome 1q21 (성모)", "FISH_IGH-MAFB Fusion Gene (성모)", "FISH_Centromere 8 (성모)", "FISH_Chromosome 20q (성모)", "FISH_Chromosome 5q (성모)", "FISH_ATM Gene (성모)", "FISH_Centromere 12 (성모)", "FISH_IGH/c-MYC(성모)", "FISH_CEP X-Y(성모)", "FISH_20q12", "FISH_D7S522, 7q31", "FISH_CLL Panel", "NGS동반진단검사", "FISH_IGH Gene", "FISH_CCND1 (여의도성모)", "FISH_IGH::CCND1 Fusion Gene", "FISH_MDS AA Panel", "FISH_MDS Dx panel", "FISH_FIP1L1::PDGFRA Fusion Gene", "FISH_PDGFRB Gene", "FISH_PDGFRA", "FISH_PDGFRB Gene", "FIP1L1/PDGFRA", "FISH_N-MYC Amplification", "EGFR (IHC)", "EGFR (IHC)(삼성)", "EGFR (IHC)(여의도성모)", "EGFR (IHC)(SCL)", "FISH_PML::RARA Fusion Gene", "FISH_PML-RARA Fusion Gene", "FISH_PML-RARA", "FISH_Miller-Dieker", "FISH_XY (AF)", "FISH_XY Chromosome (AF)", "FISH_XY & Culture (AF)", "FISH_XY (CVS)", "FISH_XY & Culture (CVS)", "FISH_XY (PB)", "FISH_XY & Culture (PB)", "FISH_SRY (PB)", "FISH_SRY & Culture (PB)", "FISH_XY", "FISH_FGFR1", "FISH_IGH::MYC Fusion Gene", "FISH_IGH::BCL2 Fusion Gene", "FISH_MYC", "FISH_1p36 deletion", "FISH_19q13 deletion", "FISH_IGH-BCL2 Gene", "ETV6::RUNX1(TEL::AML1) rearrangement PCR", "TEL/AML1 realtime PCR 정량", "CBFB-MYH11-inv(16) RQ-PCR", "E2A/PBX(TCF3-PBX1) RT PCR", "PABPN1 gene mutation", "CDH1 mutation", "AHC;NR0B1 gane mutation", "CLAH;STAR gene mutation", "FOXP3 gene mutation", "TP53 gene mutation", "TP53 Gene, Mutation(AML)", "TP53 gene, Mutation(seqencing)", "CADASIL (NOTCH3)", "CADASIL.NOTCH3 gene test(성모)", "지놈헬스 남성암(5A)", "지놈헬스 프리미엄(남)", "지놈헬스 프리미엄(여)", "PMP22 gene, duplication (CMT1A)", "CMT1A, PMP22  duplication (아산)", "MFN2 gene mutation (CMT2A)", "CMT2A MFN2 유전자검사", "DRPLA gene mutation", "DRPLA gene mutation", "DMD gene mutation", "CACNA1A gene mutation", "AGL gene mutation (삼성)", "Marfan, FBN1 gene mutation", "Marfan, FBN1 gene mutation", "UNC13D gene mutation", "PRF1 gene mutation", "PTPN11 gene mutation(Noonan/Leopard syndrome)", "PTPN11 gene mutation", "PTPN11 gene mutation (아산)", "KCNJ11 gene mutation (아산)", "KMT2D gene mutation (아산)", "PHEX gene mutation", "HEXA (hexosaminidase A)(아산)", "CYP17A1 gene (아산)", "SLC22A12 (URAT1)", "HAX1 gene mut" });
            this.TestCodeTextBox.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TestCodeTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TestCodeTextBox.Location = new System.Drawing.Point(228, 57);
            this.TestCodeTextBox.Name = "TestCodeTextBox";
            this.TestCodeTextBox.Size = new System.Drawing.Size(275, 26);
            this.TestCodeTextBox.TabIndex = 17;
            this.TestCodeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TestCodeTextBox.TextChanged += new System.EventHandler(this.TestCodeTextBox_TextChanged);
            // 
            // resultContainer
            // 
            this.resultContainer.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.resultContainer.Location = new System.Drawing.Point(228, 89);
            this.resultContainer.Name = "resultContainer";
            this.resultContainer.Size = new System.Drawing.Size(275, 313);
            this.resultContainer.TabIndex = 30;
            this.resultContainer.Visible = false;
            // 
            // Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(922, 405);
            this.Controls.Add(this.resultContainer);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.LabelSettingDataView);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LabelSettingDrop);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TestCodeTextBox);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.HospitalTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "Setting";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.FlowLayoutPanel resultContainer;

        private System.Windows.Forms.TextBox TestCodeTextBox;

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label7;

        private System.Windows.Forms.ListBox LabelSettingDataView;

        private System.Windows.Forms.Label label6;

        private System.Windows.Forms.Button SaveButton;

        private System.Windows.Forms.Label label5;

        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.ComboBox LabelSettingDrop;

        private System.Windows.Forms.Button DeleteButton;

        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox HospitalTextBox;
        private System.Windows.Forms.Button CloseButton;

        private System.Windows.Forms.Label label1;

        #endregion
    }
}