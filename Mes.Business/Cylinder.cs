namespace Mes.Business
{
    /// <summary>
    /// 一个双电控气缸：两个电磁阀（原点侧 / 动点侧）+ 两个磁感应开关（到位信号）。
    /// 四个地址全是 数据\IO输入输出表.csv 里真有的行，名字不在这里抄——
    /// 界面拿地址去 IoCatalog.Find 反查表里的信号名，免得同一件事存两份。
    /// </summary>
    public class Cylinder
    {
        public string HomeValve;
        public string WorkValve;
        public string HomeSensor;
        public string WorkSensor;
    }
}
