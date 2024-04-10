namespace PamNotes;

public partial class notes : ContentPage
{//DCIM/MEDIA/com.whatsapp.media
    string path = Path.Combine(FileSystem.AppDataDirectory, "notes.txt");
    string content = "";

    public notes()
    {
        InitializeComponent();
        if (File.Exists(path))
        {
            //Carrega o conteúdo do arquivo no editor de texto
            FileEditor.Text = File.ReadAllText(path);
        }
    }

    private void SaveButton_Clicked(object sender, EventArgs e)
    {
        //Pegar o que o usuário escreveu
        content = FileEditor.Text;

        //Criar o arquivo com esse conteúdo
        File.WriteAllText(path, content);
        DisplayAlert("Sucesso", "Arquivo salvo com sucesso", "OK");
    }

    private void DeleteButton_Clicked(object sender, EventArgs e)
    {
        if (File.Exists(path))
        {
            File.Delete(path);
            FileEditor.Text = "";
            //Alert
            DisplayAlert("Sucesso", "Arquivo deletado com sucesso", "OK");
        }
    }
}