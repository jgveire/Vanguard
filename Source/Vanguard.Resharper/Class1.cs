using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JetBrains.Application.DataContext;
using JetBrains.Application.Progress;
using JetBrains.ProjectModel;
using JetBrains.ReSharper.Feature.Services.Refactorings;
using JetBrains.ReSharper.Refactorings.Workflow;

namespace Vanguard.Resharper
{
    public class MakeSingletonRefactoring
        : DrivenRefactoring<MakeSingletonWorkflow,
            RefactoringExecBase<MakeSingletonWorkflow,
                MakeSingletonRefactoring>>
    {
        public MakeSingletonRefactoring(MakeSingletonWorkflow workflow, ISolution solution, IRefactoringDriver driver)
            : base(workflow, solution, driver)
        {
        }

        public override bool Execute(IProgressIndicator pi)
        {
            return true;
        }
    }

    [RefactoringWorkflowProvider]
    public class MakeSingletonProvider : IRefactoringWorkflowProvider
    {
        public IEnumerable<IRefactoringWorkflow> CreateWorkflow(IDataContext dataContext)
        {
            var solution = dataContext.GetData(JetBrains.ProjectModel.DataContext.DataConstants.SOLUTION);
            yield return new MakeSingletonWorkflow(solution, "MakeSingleton");
        }
    }
}
