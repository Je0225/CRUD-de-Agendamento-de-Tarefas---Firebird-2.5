namespace GestaoDeTarefas {

  public class FormBase : Form {

    protected FormBase() {
      KeyPreview = true;
      KeyDown += (sender, args) => {
        if (args.KeyCode == Keys.Enter) {
          SelectNextControl(ActiveControl, !args.Shift, true, true, true);
        }
      };
    }
  }
}
