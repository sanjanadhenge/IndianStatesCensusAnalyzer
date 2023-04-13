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
    }
}