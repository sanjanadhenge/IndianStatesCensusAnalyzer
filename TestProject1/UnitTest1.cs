using IndianStatesCensusAnalyzer;

namespace TestProject1
{
    public class Tests
    {

        public string filePath = @"C:\Users\SOURABH\Desktop\Day 3\TestProject2\Data\StateCensusData - StateCensusData.csv";
       //TC1.1
        [Test]
        public void GivenStateCensusData_WhenAnalyze_ShouldReturnNoOfRecordsMatches()
        {
            InformationAnalyze informationAnalyze = new InformationAnalyze();
            StateCensus stateCensus = new StateCensus();
            Assert.AreEqual(informationAnalyze.ReadData(filePath), stateCensus.ReadData(filePath));
        }
        //TC1.2
        [Test]
        public void GivenStateCensusDataFileInCorrect_WhenAnalyze_ShouldReturnException()
        {
            string filePath1 = @"C:\Users\SOURABH\Desktop\Day 3\TestProject2\Data\StateCensusDataStateCensusData.csv";
            InformationAnalyze informationAnalyze = new InformationAnalyze();
            try
            {
                int records = informationAnalyze.ReadData(filePath1);
            }
            catch (StateCensusException ex)
            {
                Assert.AreEqual(ex.Message, "File is incorrect");
            }
        }
        //TC1.3
        [Test]
        public void GivenStateCensusDataFileInCorrectDelimiter_WhenAnalyze_ShouldReturnException()
        {

            InformationAnalyze informationAnalyze = new InformationAnalyze();
            try
            {
                int records = informationAnalyze.ReadData(@"C:\Users\SOURABH\Desktop\Day 3\IndianStatesCensusAnalyzer\TestProject1\Files\Delimiter.csv");
            }
            catch (StateCensusException ex)
            {
                Assert.AreEqual(ex.Message, "Delimiter is incorrect");
            }
        }
        //TC1.4
        [Test]
        public void GivenStateCensusDataFileInCorrectType_WhenAnalyze_ShouldReturnException()
        {

            InformationAnalyze informationAnalyze = new InformationAnalyze();
            try
            {
                int records = informationAnalyze.ReadData(@"C:\Users\SOURABH\Desktop\Day 3\IndianStatesCensusAnalyzer\TestProject1\Files\StateCensusData.txt");
            }
            catch (StateCensusException ex)
            {
                Assert.AreEqual(ex.Message, "Type is incorrect");
            }
        }
        //TC1.5
        [Test]
        public void GivenStateCensusDataFileInCorrectHeader_WhenAnalyze_ShouldReturnException()
        {

            InformationAnalyze informationAnalyze = new InformationAnalyze();
            try
            {
                bool records = informationAnalyze.ReadData(@"C:\Users\SOURABH\Desktop\Day 3\IndianStatesCensusAnalyzer\TestProject1\Files\IncorrectHeader.csv", "state,city,population,densityPerSqKm");
            }
            catch (StateCensusException ex)
            {
                Assert.AreEqual(ex.Message, "Header is incorrect");
            }
        }
        public string filePath2 = @"C:\Users\SOURABH\Desktop\Day 3\IndianStatesCensusAnalyzer\TestProject1\Files\StateCode - StateCode.csv";
        //TC2.1
        [Test]
        public void GivenStateCodeData_WhenAnalyze_ShouldReturnNoOfRecordsMatches()
        {
           CodeAnalyze codeAnalyze = new CodeAnalyze();
           AnalyzeStateCode analyzeStateCode = new AnalyzeStateCode();
            Assert.AreEqual(codeAnalyze.ReadData(filePath2), analyzeStateCode.ReadData(filePath2));
        }
        //TC2.2
        [Test]
        public void GivenStateCodeDataFileInCorrect_WhenAnalyze_ShouldReturnException()
        {
            string filePath1 = @"C:\Users\SOURABH\Desktop\Day 3\IndianStatesCensusAnalyzer\TestProject1\Files\StateCodeStateCode.csv";
            CodeAnalyze codeAnalyze = new CodeAnalyze();
            try
            {
                int records = codeAnalyze.ReadData(filePath1);
            }
            catch (StateCensusException ex)
            {
                Assert.AreEqual(ex.Message, "File is incorrect");
            }
        }
        //TC2.3
        [Test]
        public void GivenStateCodeDataFileInCorrectDelimiter_WhenAnalyze_ShouldReturnException()
        {

            CodeAnalyze codeAnalyze = new CodeAnalyze();
            try
            {
                int records = codeAnalyze.ReadData(@"C:\Users\SOURABH\Desktop\Day 3\IndianStatesCensusAnalyzer\TestProject1\Files\DelimiterCode.csv");
            }
            catch (StateCensusException ex)
            {
                Assert.AreEqual(ex.Message, "Delimiter is incorrect");
            }
        }
        //TC2.4
        [Test]
        public void GivenStateCodeDataFileInCorrectType_WhenAnalyze_ShouldReturnException()
        {

            CodeAnalyze codeAnalyze = new CodeAnalyze();
            try
            {
                int records = codeAnalyze.ReadData(@"C:\Users\SOURABH\Desktop\Day 3\IndianStatesCensusAnalyzer\TestProject1\Files\Code.txt");
            }
            catch (StateCensusException ex)
            {
                Assert.AreEqual(ex.Message, "Type is incorrect");
            }
        }
        //TC2.5
        [Test]
        public void GivenStateCodeDataFileInCorrectHeader_WhenAnalyze_ShouldReturnException()
        {

            CodeAnalyze codeAnalyze = new CodeAnalyze();
            try
            {
                bool records = codeAnalyze.ReadData(@"C:\Users\SOURABH\Desktop\Day 3\IndianStatesCensusAnalyzer\TestProject1\Files\IncorrectHeaderCode.csv", "SrNo,StateName,TIN,StateCode");
            }
            catch (StateCensusException ex)
            {
                Assert.AreEqual(ex.Message, "Header is incorrect");
            }
        }
    }
}