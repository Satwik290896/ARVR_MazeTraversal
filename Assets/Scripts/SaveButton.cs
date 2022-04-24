using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;
using TMPro;
using System.Net;
using System.Net.Mail;

public class SaveButton : MonoBehaviour
{
    public GameObject MazeObj;
    public static bool to_save;
    public Image image;
    private CanvasGroup canvasGroup;
    public TextMeshProUGUI TMP_text;
    public TextMeshProUGUI Score;

    public class wallObject
    {
        public Transform[] _transform;
        //public string csc_obj;
    }
    public class save_load
    {
        public wallObject[] Objects;

    }
    // Start is called before the first frame update
    void Start()
    {
        to_save = false;
        //MazeObj = GameObject.FindGameObjectWithTag("Maze");
        //image = GameObject.FindGameObjectWithTag("Saving_tag");
        canvasGroup = image.GetComponent<CanvasGroup>();
        canvasGroup.alpha = 0f;
        Score = TMP_text.GetComponent<TMPro.TextMeshProUGUI>();
        int score = 10000;
        Score.text = "Objects: " + score.ToString();

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void TaskOnClick()
    {
        int count = 0;
        Score = TMP_text.GetComponent<TMPro.TextMeshProUGUI>();
        Score.text = "Objects: " + count.ToString();

        canvasGroup = image.GetComponent<CanvasGroup>();
        canvasGroup.alpha = 1f;
        save_load sv_class = new save_load();
        //canvasGroup.alpha = 0f;
        //MazeObj = GameObject.FindGameObjectWithTag("Maze");
        Transform[] g_objs = MazeObj.GetComponentsInChildren<Transform>();
        if (g_objs == null)
        {
            count = 3000;
            Score.text = "Objects: " + count.ToString();

        }
        else {
            count = 2000 + g_objs.Length;
            Score.text = "Objects: " + count.ToString();

        }

        wallObject w_obj = new wallObject();
        w_obj._transform = g_objs;
        count = g_objs.Length;
        Score.text = "Objects: " + count.ToString();
        count = 0;
        /*for (int i = 0; i < g_objs.Length; i++)
        {
            count = count + 1;
            Score.text = "Objects: " + count.ToString();
            //if (g_objs[i].tag != "Cell22") {
            wallObject w_obj = new wallObject();
                //w_obj._transform = g_obj.transform;
            w_obj._transform = g_objs[i];
                //w_obj.csc_obj = g_objs[i].tag;
            //sv_class.Objects.Add(w_obj);
            //}
            
            //Score.text = "Objects: " + count.ToString();

        }*/
        //email_send();
        //canvasGroup.alpha = 0f;

        var outputString = JsonUtility.ToJson(w_obj);
        to_save = true;
        var path = Application.persistentDataPath + "/game_save_load.json";
        //var path = "This Headset/Download/game_save_load.json";
        File.WriteAllText(path, outputString);
        canvasGroup.alpha = 1f;



    }


    public void email_send()
    {
        MailMessage mail = new MailMessage();
        SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
        mail.From = new MailAddress("vsaisatwik1996@gmail.com");
        mail.To.Add("vsaisatwik1996@gmail.com");
        mail.Subject = "Test Mail - 1";
        mail.Body = "mail with attachment";

        /*System.Net.Mail.Attachment attachment;
        attachment = new System.Net.Mail.Attachment("c:/textfile.txt");
        mail.Attachments.Add(attachment);*/

        SmtpServer.Port = 587;
        SmtpServer.Credentials = new System.Net.NetworkCredential("vsaisatwik1996@gmail.com", "Cp-X@m03");
        SmtpServer.EnableSsl = true;

        SmtpServer.Send(mail);

    }

}
