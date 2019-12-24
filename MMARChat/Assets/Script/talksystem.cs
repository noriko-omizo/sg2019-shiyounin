using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Video;
using UnityEngine.Playables;


public class talksystem : MonoBehaviour
{

    [SerializeField] InputField input;
    [SerializeField] RectTransform timeline;
    [SerializeField] RectTransform meFukidashi;
    [SerializeField] RectTransform toFukidashi1;
    [SerializeField] RectTransform toFukidashi2;
    [SerializeField] RectTransform toFukidashi3;

    [SerializeField] Player player;

    [SerializeField] GameObject arCanvas;
    [SerializeField] GameObject startCanvas;
    [SerializeField] GameObject chatCanvas;

    [SerializeField] GameObject keyPanel;


    public ScrollRect scrollRect;

    private VideoPlayer videoPlayer;
    bool reply1 = true;
    bool reply2;
    bool reply3 = true;
    bool reply4 = true;
    bool reply5 = true;
    bool reply6 = true;
    bool reply7 = true;
    //////////hint////////////
    bool hint1 = false;
    bool hint11 = true;
    bool hint12 = false;
    bool hint13 = false;
    bool hint2 = false;
    bool hint21 = true;
    bool hint22 = false;
    bool hint23 = false;
    bool hint3 = false;
    bool hint31 = true;
    bool hint32 = false;
    bool hint33 = false;
    bool hint4 = false;
    bool hint41 = true;
    bool hint42 = false;
    bool hint43 = false;
    bool hint5 = false;
    bool hint51 = true;
    bool hint52 = false;
    bool hint53 = false;

    //////////hint//////////////


    bool talk = true;

    float timelineheight;


    bool keygive = false;



    public PlayableDirector playableDirector;




    void Start()
    {

        arCanvas.SetActive(false);
        videoPlayer = GetComponent<VideoPlayer>();
    }

    public void OnSubmit()
    {
        string userText = input.text;
        if (userText == "")
        {
            return;
        }

        input.text = string.Empty;
        CreateFukidashi(meFukidashi, userText);

        if (userText != ("") && reply1)
        {
            player.hasKey1 = true;
            reply1 = false;
            playableDirector.Resume();
        }

        if (userText == ("トオン") && player.hasKey1 && reply2)
        {
            playableDirector.Resume();
            player.hasKey2 = true;
            reply2 = false;
        }
        if (userText == ("ヒント") && player.hasKey2 && hint1)
        {
            if (hint11)
            {
                hint11 = false;
                hint12 = true;
                CreateFukidashi(toFukidashi1, "M-Mで写すと破れていた紙が元に戻ったね。");

            }
            else if (hint12)
            {
                hint12 = false;
                hint13 = true;
                CreateFukidashi(toFukidashi3, "<color=#ff0000>上から読め</color>も<color=#ff0000>丸を上から読め</color>に\nなっているわ！");
            }
            else if (hint13)
            {
                hint13 = false;
                hint1 = false;
                CreateFukidashi(toFukidashi2, "元に戻った<color=#ff0000>文字の色</color>も\nヒントになっていそうですよ。");
            }
        }


        if (userText == ("かほう") && player.hasKey2 && reply3)
        {
            player.hasKey3 = true;
            reply3 = false;
            playableDirector.Resume();
        }
        if (userText == ("ヒント") && player.hasKey3 && hint2)
        {
            if (hint21)
            {
                hint21 = false;
                hint22 = true;
                CreateFukidashi(toFukidashi1, "模様に見えるけど、<color=#ff0000>１つ１つの形に決まりが\nあって</color>並んでいそうだ。");

            }
            else if (hint22)
            {
                hint22 = false;
                hint23 = true;
                CreateFukidashi(toFukidashi3, "全部で<color=#ff0000>６つの模様</color>みたいですね。");
            }
            else if (hint23)
            {
                hint23 = false;
                hint2 = false;
                CreateFukidashi(toFukidashi2, "１つの模様を真ん中で折ると、\n<color=#ff0000>ぴったり同じかたちになる</color>ようです。");
            }
        }

        if (userText == ("キャラクター") || userText == ("きゃらくたー") && player.hasKey3 && reply4)
        {
            player.hasKey4 = true;
            reply4 = false;
            playableDirector.Resume();
        }
        if (userText == ("ヒント") && player.hasKey4 && hint3)
        {
            if (hint31)
            {
                hint31 = false;
                hint32 = true;
                CreateFukidashi(toFukidashi1, "この四角が並んだ図、組み立てると\n<color=#ff0000>サイコロの形</color>になりそうだ。");

            }
            else if (hint32)
            {
                hint32 = false;
                hint33 = true;
                CreateFukidashi(toFukidashi2, "文字と模様はどれも組み立てた時に、\n<color=#ff0000>裏と表</color>になるように書いてあるようです。");
            }
            else if (hint23)
            {
                hint33 = false;
                hint3 = false;
                CreateFukidashi(toFukidashi3, "サイコロの数字は裏と表の数字を足すと、\nどれも<color=#ff0000>７</color>になるのよね！");
            }
        }

        if (userText == ("じゆう") && player.hasKey4 && reply5)
        {
            player.hasKey5 = true;
            reply5 = false;
            playableDirector.Resume();
        }
        if (userText == ("ヒント") && player.hasKey5 && hint4)
        {
            if (hint41)
            {
                hint41 = false;
                hint42 = true;
                CreateFukidashi(toFukidashi1, "この四角が並んだ図、組み立てると\n<color=#ff0000>サイコロの形</color>になりそうだ。");

            }
            else if (hint42)
            {
                hint42 = false;
                hint43 = true;
                CreateFukidashi(toFukidashi2, "文字と模様はどれも組み立てた時に、\n<color=#ff0000>裏と表</color>になるように書いてあるようです。");
            }
            else if (hint43)
            {
                hint43 = false;
                hint4 = false;
                CreateFukidashi(toFukidashi3, "サイコロの数字は裏と表の数字を足すと、\nどれも<color=#ff0000>７</color>になるのよね！");
            }
        }

        if (userText == ("おもいやり") && player.hasKey5 && reply6)
        {
            player.hasKey6 = true;
            reply6 = false;
            playableDirector.Resume();
        }
        if (userText == ("ヒント５") && hint5 && player.hasKey6)
        {

            hint3 = false;
        }
        if (userText == ("まんがか") && player.hasKey6 && reply7)
        {
            player.hasKey7 = true;
            reply7 = false;
            playableDirector.Resume();
        }



        if (userText == ("あいことば"))
        {
            arCanvas.SetActive(false);
            chatCanvas.SetActive(false);
            videoPlayer.Play();
            Debug.Log("start");
        }

        if (userText == ("リセット"))
        {

            // player.hasKey1 = false;
            // player.hasKey2 = false;
            // player.hasKey3 = false;

            SceneManager.LoadScene("Chat");


            startCanvas.SetActive(true);

        }

        // if (userText == ("マップ"))
        // {
        //     CreateImage(mapMap1);

        // }


    }

    void Update()
    {

        if (player.entrance)
        {
            playableDirector.Play();
        }
        //		Debug.Log (videoPlayer.frame +", "+ videoPlayer.frameCount);
        if (videoPlayer.frame != 0 && ((int)videoPlayer.frame == (int)videoPlayer.frameCount - 1200))
        {
            videoPlayer.Stop();
            arCanvas.SetActive(true);
            chatCanvas.SetActive(true);
            playableDirector.Resume();

        }

        if (timelineheight != timeline.rect.height)
        {
            updateScroll();
            // timelineheight = timeline.rect.height;
            //Debug.Log(timeline.rect.height);
        }


    }

    ///////////////////M-M起動/////////////////
    // Timeline から呼ばれるセリフ
    public void openning1()
    {
        CreateFukidashi(toFukidashi1, "<color=#ff0000>チャット</color>は見れたかな？\n見えていたら何か文字を打ってくれ。");
        player.entrance = false;
        playableDirector.Pause();
    }

    public void openning2()
    {
        CreateFukidashi(toFukidashi1, "操作は大丈夫そうだね！\n途中わからないことがあれば、\nそこにいる使用人に聞いてくれ。");
    }
    public void openning3()
    {
        CreateFukidashi(toFukidashi1, "今回手伝ってくれる2人だ。");

    }
    public void openning4()
    {
        CreateFukidashi(toFukidashi2, "執事のホワイトと申します。\nどうぞよろしくお願いします。");
    }

    public void openning5()
    {
        CreateFukidashi(toFukidashi3, "メイドのプロットです。\nみなさんのお役に立てるよう頑張ります！");

    }
    public void openning6()
    {
        CreateFukidashi(toFukidashi1, "最初の謎は<color=#ff0000>〇〇</color>にあるみたいだ。\n詳しい場所は使用人が案内してくれる。");

    }
    public void openning7()
    {
        CreateFukidashi(toFukidashi1, "目的地に着いたら、チャットで\n<color=#ff0000>『トオン』</color>と打って僕を呼んでくれ！");
        reply2 = true;
    }
    public void openning8()
    {
        CreateFukidashi(toFukidashi1, "早速進もう！");
        playableDirector.Pause();
    }

    ////////////////////謎解き開始////////////////////////
    public void nazotoki11()
    {
        CreateFukidashi(toFukidashi1, "目的地に着いたかな？");
    }
    public void nazotoki12()
    {
        CreateFukidashi(toFukidashi1, "ナゾが書かれた紙が破れて\n問題が解けなくなっているね…。");
    }
    public void nazotoki13()
    {
        CreateFukidashi(toFukidashi1, "こんな時は<color=#ff0000>M-M</color>を使おう！");
    }
    public void nazotoki14()
    {
        CreateFukidashi(toFukidashi1, "君たちが持っているM-Mには、\n<color=#ff0000>カメラで写した物の見えない部分を\n写す力</color>があるんだ！");
    }
    public void nazotoki15()
    {
        CreateFukidashi(toFukidashi1, "このナゾもM-Mがあれば、解けるはず。\nM-Mのカメラを起動して<color=#ff0000>ナゾが書かれた\n紙に向けてみてくれ！</color>");
    }
    public void nazotoki16()
    {
        CreateFukidashi(toFukidashi1, "このナゾの答えがわかったら、\nチャットで僕たちにも教えてくれ。");
    }
    public void nazotoki17()
    {
        CreateFukidashi(toFukidashi1, "もしナゾが解けない時はチャットに\n<color=#ff0000>『ヒント』</color>と打ってくれ。\n僕たちも一緒に考えるよ。");
        hint1 = true;
        player.aruse = true;
        playableDirector.Pause();
    }
    //////////オープニング完////////
    public void nazotoki21()
    {
        CreateFukidashi(toFukidashi1, "なるほど！カホウが答えだったのか！");
    }
    public void nazotoki22()
    {
        CreateFukidashi(toFukidashi1, "僕の家には家宝がたくさんあるんだ。\n君が持っているM-Mも家宝の一つなんだよ。");
    }
    public void nazotoki23()
    {
        CreateFukidashi(toFukidashi1, "次のナゾは<color=#ff0000>〇〇</color>にあるみたいだ。");
    }
    // public void nazotoki11()
    // {
    //     CreateFukidashi(toFukidashi1, "ナゾを見つけたらM-Mを使って\nナゾを解いていってくれ。");
    // }
    // public void nazotoki12()
    // {
    //     CreateFukidashi(toFukidashi1, "ナゾが解けない時は<color=#ff0000>『ヒント』</color>と\n打って僕たちと相談しよう。");
    // }
    public void nazotoki24()
    {
        CreateFukidashi(toFukidashi1, "使用人と向かってくれ。");
        playableDirector.Pause();
        hint2 = true;
    }
    //////////////謎１完////////////////
    public void nazotoki31()
    {
        CreateFukidashi(toFukidashi1, "そうか！キャラクターが答えだ！");
    }
    public void nazotoki32()
    {
        CreateFukidashi(toFukidashi1, "僕たち漫画家にとってキャラクターは\n切っても切り離せないくらい大事な存在だ。");
        // playableDirector.Pause();
    }
    public void nazotoki33()
    {
        CreateFukidashi(toFukidashi1, "次のナゾは<color=#ff0000>〇〇</color>にあるみたいだ。");

    }
    // public void nazotoki17()
    // {
    //     CreateFukidashi(toFukidashi1, "ナゾが解けない時は<color=#ff0000>ヒントワード</color>を\n打って僕たちと相談しよう。");
    // }
    public void nazotoki34()
    {
        CreateFukidashi(toFukidashi1, "準備ができたら次に進もう！");
        playableDirector.Pause();
        hint3 = true;
    }

    /////////////謎２完///////////

    public void nazotoki41()
    {
        CreateFukidashi(toFukidashi1, "答えはじゆうになるのか！");
    }
    public void nazotoki42()
    {
        CreateFukidashi(toFukidashi1, "今では漫画は好きなものを好きな\nようにかいて皆に見てもらえるけど\n昔はどんなに面白くても世の中に\n出せなかった漫画があったんだ。");
        // playableDirector.Pause();
    }
    public void nazotoki43()
    {
        CreateFukidashi(toFukidashi1, "次のナゾは<color=#ff0000>〇〇</color>にあるみたいだ。");

    }
    public void nazotoki44()
    {
        CreateFukidashi(toFukidashi1, "準備ができたら次に進もう！");
        playableDirector.Pause();
    }
    /////////////謎３完///////////

    public void nazotoki51()
    {
        CreateFukidashi(toFukidashi1, "答えはおもいやりになるのか！");
    }
    public void nazotoki52()
    {
        CreateFukidashi(toFukidashi1, "今では漫画は好きなものを好きな\nようにかいて皆に見てもらえるけど\n昔はどんなに面白くても世の中に\n出せなかった漫画があったんだ。");
        // playableDirector.Pause();
    }
    public void nazotoki53()
    {
        CreateFukidashi(toFukidashi1, "次のナゾは<color=#ff0000>〇〇</color>にあるみたいだ。");

    }
    public void nazotoki54()
    {
        CreateFukidashi(toFukidashi1, "準備ができたら次に進もう！");
        playableDirector.Pause();
    }
    /////////////謎4完///////////

    public void nazotoki61()
    {
        CreateFukidashi(toFukidashi1, "答えはまんがかになるのか！");
    }
    public void nazotoki62()
    {
        CreateFukidashi(toFukidashi1, "今では漫画は好きなものを好きな\nようにかいて皆に見てもらえるけど\n昔はどんなに面白くても世の中に\n出せなかった漫画があったんだ。");
        // playableDirector.Pause();
    }
    public void nazotoki63()
    {
        CreateFukidashi(toFukidashi1, "次のナゾは<color=#ff0000>〇〇</color>にあるみたいだ。");

    }
    public void nazotoki64()
    {
        CreateFukidashi(toFukidashi1, "準備ができたら次に進もう！");
        playableDirector.Pause();
    }
    /////////////謎5完///////////

    ////////////////鍵入手後//////////////////
    public void ending1()
    {
        CreateFukidashi(toFukidashi1, "鍵を手に入れた");
    }

    public void ending2()
    {
        CreateFukidashi(toFukidashi1, "鍵を渡しにいこう");
    }
    public void ending3()
    {
        keyPanel.SetActive(true);
    }
    /////////////////////////////////

    void CreateFukidashi(RectTransform fukidashi, string serifu)
    {
        var to = Instantiate(fukidashi);
        to.GetComponentInChildren<Text>().text = serifu;
        to.SetParent(timeline);
        to.SetAsLastSibling();

    }

    // void CreateImage(RectTransform map)
    // {
    //     var to = Instantiate(map);
    //     to.GetComponentInChildren<Image>();
    //     to.SetParent(timeline);
    //     to.SetAsLastSibling();
    // }

    [ContextMenu("updateScroll")]
    void updateScroll()
    {
        timeline.GetComponent<ContentSizeFitter>().SetLayoutVertical();
        scrollRect.verticalNormalizedPosition = 0f;
    }
}
