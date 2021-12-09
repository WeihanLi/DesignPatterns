#region Prototype

var originator = new Originator
{
    State = "On"
};
originator.Show();

var caretaker = new Caretaker
{
    Memento = originator.CreateMemento()
};

originator.State = "Off";
originator.Show();

originator.SetMemento(caretaker.Memento);
originator.Show();

Console.WriteLine();

#endregion Prototype

var lixiaoyao = new GameRole();
lixiaoyao.StateDisplay();

//保存状态
var stateCaretaker = new RoleStateCaretaker
{
    Memento = lixiaoyao.SaveState()
};

// 大战 Boss
lixiaoyao.FightWithBoss();
lixiaoyao.StateDisplay();

// 快被 Boss 打挂了，恢复之前的状态，继续打
lixiaoyao.RecoveryState(stateCaretaker.Memento);
lixiaoyao.StateDisplay();

Console.ReadLine();
