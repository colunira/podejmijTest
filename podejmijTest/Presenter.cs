using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace podejmijTest
{
    class Presenter
    {
        IView view;
        Model model;
        public Presenter(IView view, Model model)
        {
            this.view = view;
            this.model = model;
            view.ReadXML += View_ReadXML;
            view.GetTestProperties += View_GetTestProperties;
            view.StartTest += View_StartTest;
            view.NextQuestion += View_NextQuestion;
            view.SaveCheckedAnswers += View_SaveCheckedAnswers;
            view.FinishTest += View_FinishTest;
        }

        private void Model_TimesUp()
        {
            View_FinishTest();
        }

        private void View_FinishTest()
        {
            int[] result=model.CalculateResult();
            view.ShowResults(result[0], result[1]);
            Reset();
        }

        private void View_SaveCheckedAnswers()
        {
            model.SaveCheckedAnswers(view.QuestionsSelected);
        }

        #region Actions
        private void View_NextQuestion(string whichWay)
        {
            model.NextQuestion(whichWay);
            Refresh();
        }

        private void View_StartTest()
        {
            Refresh();
        }

        private void View_GetTestProperties()
        {
            view.TestName = model.ReturnTestName;
            view.Level = model.ReturnTestLevel;
            view.Author = model.ReturnTestAuthor;
            view.Time = model.ReturnTestTime.ToString();
            view.TimeValue = model.ReturnTestTime;
        }

        private void View_ReadXML(string path)
        {
            model.readXML(path);
        }
        #endregion
        private void Refresh()
        {
            view.QuestionsAmount = model.ReturnQuestionsAmount;
            view.QuestionText = model.ReturnCurrentQuestionText;
            view.Questions = model.ReturnCurrentQuestionAnswers;
            view.QuestionsSelected = model.ReturnCheckedAnsers;
        }
        private void Reset()
        {
            view.QuestionsAmount = new int[] { 0, 0};
            view.QuestionText = "Treść pytania";
            view.Questions = new string[] { };
            view.TestName = "";
            view.Level = "";
            view.Author = "";
            view.Time = "∞";
        }
    }
}
