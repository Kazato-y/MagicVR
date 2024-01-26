using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

#if UNITY_EDITOR
[CustomEditor(typeof(Transform))]       // �������邱�Ƃɂ��Transform�R���|�[�l���g�̃C���X�y�N�^�ɁA�J�X�^�����ڂ��ǉ��ł���
public class WorldPosCS : Editor {
    Transform _t = null;

    private void OnEnable() {
        _t = target as Transform;
    }

    public override void OnInspectorGUI() {
        base.OnInspectorGUI();
        EditorGUILayout.Vector3Field("World Position", _t.position);       // ���[���h���W��\������
        EditorGUILayout.Vector3Field("World Rotation", _t.rotation.eulerAngles);       // ���[���h���W��\������
    }
}
#endif