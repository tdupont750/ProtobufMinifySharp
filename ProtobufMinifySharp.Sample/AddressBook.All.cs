// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: AddressBook.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
#region Messages
public sealed partial class Person : pb::IMessage<Person>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<Person> _parser = new pb::MessageParser<Person>(() => new Person());
  private pb::UnknownFieldSet _unknownFields;
  private int _hasBits0;
  public static pb::MessageParser<Person> Parser { get { return _parser; } }
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { throw new System.NotImplementedException(); }
  }
  public Person Clone() { throw new System.NotImplementedException(); }

  private string name_;
  public string Name {
    get { return name_ ?? ""; }
    set {
      name_ = value;
    }
  }

  private int id_;
  public int Id {
    get { if ((_hasBits0 & 1) != 0) { return id_; } else { return 0; } }
    set {
      _hasBits0 |= 1;
      id_ = value;
    }
  }

  private string email_;
  public string Email {
    get { return email_ ?? ""; }
    set {
      email_ = value;
    }
  }
  private static readonly pb::FieldCodec<global::Person.Types.PhoneNumber> _repeated_phones_codec
      = pb::FieldCodec.ForMessage(34, global::Person.Types.PhoneNumber.Parser);
  private readonly pbc::RepeatedField<global::Person.Types.PhoneNumber> phones_ = new pbc::RepeatedField<global::Person.Types.PhoneNumber>();
  public pbc::RepeatedField<global::Person.Types.PhoneNumber> Phones {
    get { return phones_; }
  }

  private bool hasThing_;
  public bool HasThing {
    get { if ((_hasBits0 & 2) != 0) { return hasThing_; } else { return false; } }
    set {
      _hasBits0 |= 2;
      hasThing_ = value;
    }
  }
  public override bool Equals(object other) {
    return Equals(other as Person);
  }
  public bool Equals(Person other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (Name != other.Name) return false;
    if (Id != other.Id) return false;
    if (Email != other.Email) return false;
    if(!phones_.Equals(other.phones_)) return false;
    if (HasThing != other.HasThing) return false;
    return Equals(_unknownFields, other._unknownFields);
  }
  public override int GetHashCode() {
    int hash = 1;
    if (name_ != null) hash ^= Name.GetHashCode();
    if ((_hasBits0 & 1) != 0) hash ^= Id.GetHashCode();
    if (email_ != null) hash ^= Email.GetHashCode();
    hash ^= phones_.GetHashCode();
    if ((_hasBits0 & 2) != 0) hash ^= HasThing.GetHashCode();
    if (_unknownFields != null) {
      hash ^= _unknownFields.GetHashCode();
    }
    return hash;
  }
  public void WriteTo(pb::CodedOutputStream output) { throw new System.NotImplementedException(); }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
  void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) { throw new System.NotImplementedException(); }

#endif
  public int CalculateSize() { throw new System.NotImplementedException(); }
  public void MergeFrom(Person other) { throw new System.NotImplementedException(); }
  public void MergeFrom(pb::CodedInputStream input) {
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    input.ReadRawMessage(this);
  #else
    uint tag;
    while ((tag = input.ReadTag()) != 0) {
      switch(tag) {
        default:
          _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
          break;
        case 10: {
          Name = input.ReadString();
          break;
        }
        case 16: {
          Id = input.ReadInt32();
          break;
        }
        case 26: {
          Email = input.ReadString();
          break;
        }
        case 34: {
          phones_.AddEntriesFrom(input, _repeated_phones_codec);
          break;
        }
        case 40: {
          HasThing = input.ReadBool();
          break;
        }
      }
    }
  #endif
  }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
  void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
    uint tag;
    while ((tag = input.ReadTag()) != 0) {
      switch(tag) {
        default:
          _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
          break;
        case 10: {
          Name = input.ReadString();
          break;
        }
        case 16: {
          Id = input.ReadInt32();
          break;
        }
        case 26: {
          Email = input.ReadString();
          break;
        }
        case 34: {
          phones_.AddEntriesFrom(ref input, _repeated_phones_codec);
          break;
        }
        case 40: {
          HasThing = input.ReadBool();
          break;
        }
      }
    }
  }

#endif
#region Nested types
  public static partial class Types {
    public enum PhoneType {
      [pbr::OriginalName("MOBILE")] Mobile = 0,
      [pbr::OriginalName("HOME")] Home = 1,
      [pbr::OriginalName("WORK")] Work = 2,
    }

    public sealed partial class PhoneNumber : pb::IMessage<PhoneNumber>
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , pb::IBufferMessage
    #endif
    {
      private static readonly pb::MessageParser<PhoneNumber> _parser = new pb::MessageParser<PhoneNumber>(() => new PhoneNumber());
      private pb::UnknownFieldSet _unknownFields;
      private int _hasBits0;
      public static pb::MessageParser<PhoneNumber> Parser { get { return _parser; } }
      pbr::MessageDescriptor pb::IMessage.Descriptor {
        get { throw new System.NotImplementedException(); }
      }
      public PhoneNumber Clone() { throw new System.NotImplementedException(); }

      private string number_;
      public string Number {
        get { return number_ ?? ""; }
        set {
          number_ = value;
        }
      }

      private global::Person.Types.PhoneType type_;
      public global::Person.Types.PhoneType Type {
        get { if ((_hasBits0 & 1) != 0) { return type_; } else { return global::Person.Types.PhoneType.Mobile; } }
        set {
          _hasBits0 |= 1;
          type_ = value;
        }
      }
      public override bool Equals(object other) {
        return Equals(other as PhoneNumber);
      }
      public bool Equals(PhoneNumber other) {
        if (ReferenceEquals(other, null)) {
          return false;
        }
        if (ReferenceEquals(other, this)) {
          return true;
        }
        if (Number != other.Number) return false;
        if (Type != other.Type) return false;
        return Equals(_unknownFields, other._unknownFields);
      }
      public override int GetHashCode() {
        int hash = 1;
        if (number_ != null) hash ^= Number.GetHashCode();
        if ((_hasBits0 & 1) != 0) hash ^= Type.GetHashCode();
        if (_unknownFields != null) {
          hash ^= _unknownFields.GetHashCode();
        }
        return hash;
      }
      public void WriteTo(pb::CodedOutputStream output) { throw new System.NotImplementedException(); }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) { throw new System.NotImplementedException(); }

#endif
      public int CalculateSize() { throw new System.NotImplementedException(); }
      public void MergeFrom(PhoneNumber other) { throw new System.NotImplementedException(); }
      public void MergeFrom(pb::CodedInputStream input) {
      #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        input.ReadRawMessage(this);
      #else
        uint tag;
        while ((tag = input.ReadTag()) != 0) {
          switch(tag) {
            default:
              _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
              break;
            case 10: {
              Number = input.ReadString();
              break;
            }
            case 16: {
              Type = (global::Person.Types.PhoneType) input.ReadEnum();
              break;
            }
          }
        }
      #endif
      }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
        uint tag;
        while ((tag = input.ReadTag()) != 0) {
          switch(tag) {
            default:
              _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
              break;
            case 10: {
              Number = input.ReadString();
              break;
            }
            case 16: {
              Type = (global::Person.Types.PhoneType) input.ReadEnum();
              break;
            }
          }
        }
      }
      #endif

    }

  }
  #endregion

}

public sealed partial class AddressBook : pb::IMessage<AddressBook>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<AddressBook> _parser = new pb::MessageParser<AddressBook>(() => new AddressBook());
  private pb::UnknownFieldSet _unknownFields;
  public static pb::MessageParser<AddressBook> Parser { get { return _parser; } }
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { throw new System.NotImplementedException(); }
  }
  public AddressBook Clone() { throw new System.NotImplementedException(); }
  private static readonly pb::FieldCodec<global::Person> _repeated_people_codec
      = pb::FieldCodec.ForMessage(10, global::Person.Parser);
  private readonly pbc::RepeatedField<global::Person> people_ = new pbc::RepeatedField<global::Person>();
  public pbc::RepeatedField<global::Person> People {
    get { return people_; }
  }
  public override bool Equals(object other) {
    return Equals(other as AddressBook);
  }
  public bool Equals(AddressBook other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if(!people_.Equals(other.people_)) return false;
    return Equals(_unknownFields, other._unknownFields);
  }
  public override int GetHashCode() {
    int hash = 1;
    hash ^= people_.GetHashCode();
    if (_unknownFields != null) {
      hash ^= _unknownFields.GetHashCode();
    }
    return hash;
  }
  public void WriteTo(pb::CodedOutputStream output) { throw new System.NotImplementedException(); }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
  void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) { throw new System.NotImplementedException(); }

#endif
  public int CalculateSize() { throw new System.NotImplementedException(); }
  public void MergeFrom(AddressBook other) { throw new System.NotImplementedException(); }
  public void MergeFrom(pb::CodedInputStream input) {
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    input.ReadRawMessage(this);
  #else
    uint tag;
    while ((tag = input.ReadTag()) != 0) {
      switch(tag) {
        default:
          _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
          break;
        case 10: {
          people_.AddEntriesFrom(input, _repeated_people_codec);
          break;
        }
      }
    }
  #endif
  }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
  void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
    uint tag;
    while ((tag = input.ReadTag()) != 0) {
      switch(tag) {
        default:
          _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
          break;
        case 10: {
          people_.AddEntriesFrom(ref input, _repeated_people_codec);
          break;
        }
      }
    }
  }
  #endif

}

public sealed partial class AnotherThing : pb::IMessage<AnotherThing>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<AnotherThing> _parser = new pb::MessageParser<AnotherThing>(() => new AnotherThing());
  private pb::UnknownFieldSet _unknownFields;
  private int _hasBits0;
  public static pb::MessageParser<AnotherThing> Parser { get { return _parser; } }
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { throw new System.NotImplementedException(); }
  }
  public AnotherThing Clone() { throw new System.NotImplementedException(); }

  private string name_;
  public string Name {
    get { return name_ ?? ""; }
    set {
      name_ = value;
    }
  }

  private int id_;
  public int Id {
    get { if ((_hasBits0 & 1) != 0) { return id_; } else { return 0; } }
    set {
      _hasBits0 |= 1;
      id_ = value;
    }
  }
  public override bool Equals(object other) {
    return Equals(other as AnotherThing);
  }
  public bool Equals(AnotherThing other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (Name != other.Name) return false;
    if (Id != other.Id) return false;
    return Equals(_unknownFields, other._unknownFields);
  }
  public override int GetHashCode() {
    int hash = 1;
    if (name_ != null) hash ^= Name.GetHashCode();
    if ((_hasBits0 & 1) != 0) hash ^= Id.GetHashCode();
    if (_unknownFields != null) {
      hash ^= _unknownFields.GetHashCode();
    }
    return hash;
  }
  public void WriteTo(pb::CodedOutputStream output) { throw new System.NotImplementedException(); }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
  void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) { throw new System.NotImplementedException(); }

#endif
  public int CalculateSize() { throw new System.NotImplementedException(); }
  public void MergeFrom(AnotherThing other) { throw new System.NotImplementedException(); }
  public void MergeFrom(pb::CodedInputStream input) {
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    input.ReadRawMessage(this);
  #else
    uint tag;
    while ((tag = input.ReadTag()) != 0) {
      switch(tag) {
        default:
          _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
          break;
        case 10: {
          Name = input.ReadString();
          break;
        }
        case 16: {
          Id = input.ReadInt32();
          break;
        }
      }
    }
  #endif
  }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
  void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
    uint tag;
    while ((tag = input.ReadTag()) != 0) {
      switch(tag) {
        default:
          _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
          break;
        case 10: {
          Name = input.ReadString();
          break;
        }
        case 16: {
          Id = input.ReadInt32();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
