﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using DslModeling = global::Microsoft.VisualStudio.Modeling;
using DslDesign = global::Microsoft.VisualStudio.Modeling.Design;
using DslDiagrams = global::Microsoft.VisualStudio.Modeling.Diagrams;
namespace Ufba.ShHome
{
	/// <summary>
	/// DomainModel ShHomeDomainModel
	/// Description for Ufba.ShHome.ShHome
	/// </summary>
	[DslDesign::DisplayNameResource("Ufba.ShHome.ShHomeDomainModel.DisplayName", typeof(global::Ufba.ShHome.ShHomeDomainModel), "Ufba.ShHome.GeneratedCode.DomainModelResx")]
	[DslDesign::DescriptionResource("Ufba.ShHome.ShHomeDomainModel.Description", typeof(global::Ufba.ShHome.ShHomeDomainModel), "Ufba.ShHome.GeneratedCode.DomainModelResx")]
	[global::System.CLSCompliant(true)]
	[DslModeling::DependsOnDomainModel(typeof(global::Microsoft.VisualStudio.Modeling.CoreDomainModel))]
	[DslModeling::DependsOnDomainModel(typeof(global::Microsoft.VisualStudio.Modeling.Diagrams.CoreDesignSurfaceDomainModel))]
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1506:AvoidExcessiveClassCoupling", Justification = "Generated code.")]
	[DslModeling::DomainObjectId("65fc674b-a1ef-496d-8f44-a97e65134927")]
	public partial class ShHomeDomainModel : DslModeling::DomainModel
	{
		#region Constructor, domain model Id
	
		/// <summary>
		/// ShHomeDomainModel domain model Id.
		/// </summary>
		public static readonly global::System.Guid DomainModelId = new global::System.Guid(0x65fc674b, 0xa1ef, 0x496d, 0x8f, 0x44, 0xa9, 0x7e, 0x65, 0x13, 0x49, 0x27);
	
		/// <summary>
		/// Constructor.
		/// </summary>
		/// <param name="store">Store containing the domain model.</param>
		public ShHomeDomainModel(DslModeling::Store store)
			: base(store, DomainModelId)
		{
			// Call the partial method to allow any required serialization setup to be done.
			this.InitializeSerialization(store);		
		}
		
	
		///<Summary>
		/// Defines a partial method that will be called from the constructor to
		/// allow any necessary serialization setup to be done.
		///</Summary>
		///<remarks>
		/// For a DSL created with the DSL Designer wizard, an implementation of this 
		/// method will be generated in the GeneratedCode\SerializationHelper.cs class.
		///</remarks>
		partial void InitializeSerialization(DslModeling::Store store);
	
	
		#endregion
		#region Domain model reflection
			
		/// <summary>
		/// Gets the list of generated domain model types (classes, rules, relationships).
		/// </summary>
		/// <returns>List of types.</returns>
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1506:AvoidExcessiveClassCoupling", Justification = "Generated code.")]	
		protected sealed override global::System.Type[] GetGeneratedDomainModelTypes()
		{
			return new global::System.Type[]
			{
				typeof(ModelRoot),
				typeof(ModelClass),
				typeof(Comment),
				typeof(ModelType),
				typeof(Device),
				typeof(ModelRootHasComments),
				typeof(ModelRootHasTypes),
				typeof(CommentReferencesSubjects),
				typeof(ModelHasDevices),
				typeof(ModelTypeReferencesActuator),
				typeof(ModelTypeReferencesSensor),
				typeof(ModelTypeReferencesFather),
				typeof(ModelTypeReferencesBrother),
				typeof(ModelTypeReferencesAlternatives),
				typeof(ShHomeDiagram),
				typeof(CommentConnector),
				typeof(ActuatorConnector),
				typeof(SConnector),
				typeof(FatherConnector),
				typeof(BrotherConnector),
				typeof(AlternativesConnector),
				typeof(CommentBoxShape),
				typeof(DeviceShape),
				typeof(FShape),
				typeof(DShape),
				typeof(global::Ufba.ShHome.FixUpDiagram),
				typeof(global::Ufba.ShHome.ConnectorRolePlayerChanged),
			};
		}
		/// <summary>
		/// Gets the list of generated domain properties.
		/// </summary>
		/// <returns>List of property data.</returns>
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1506:AvoidExcessiveClassCoupling", Justification = "Generated code.")]	
		protected sealed override DomainMemberInfo[] GetGeneratedDomainProperties()
		{
			return new DomainMemberInfo[]
			{
				new DomainMemberInfo(typeof(ModelClass), "Name", ModelClass.NameDomainPropertyId, typeof(ModelClass.NamePropertyHandler)),
				new DomainMemberInfo(typeof(ModelClass), "TypeFeature", ModelClass.TypeFeatureDomainPropertyId, typeof(ModelClass.TypeFeaturePropertyHandler)),
				new DomainMemberInfo(typeof(ModelClass), "Serial", ModelClass.SerialDomainPropertyId, typeof(ModelClass.SerialPropertyHandler)),
				new DomainMemberInfo(typeof(Comment), "Text", Comment.TextDomainPropertyId, typeof(Comment.TextPropertyHandler)),
				new DomainMemberInfo(typeof(Device), "Name", Device.NameDomainPropertyId, typeof(Device.NamePropertyHandler)),
				new DomainMemberInfo(typeof(Device), "TypeDevice", Device.TypeDeviceDomainPropertyId, typeof(Device.TypeDevicePropertyHandler)),
				new DomainMemberInfo(typeof(Device), "ReturnType", Device.ReturnTypeDomainPropertyId, typeof(Device.ReturnTypePropertyHandler)),
			};
		}
		/// <summary>
		/// Gets the list of generated domain roles.
		/// </summary>
		/// <returns>List of role data.</returns>
		protected sealed override DomainRolePlayerInfo[] GetGeneratedDomainRoles()
		{
			return new DomainRolePlayerInfo[]
			{
				new DomainRolePlayerInfo(typeof(ModelRootHasComments), "ModelRoot", ModelRootHasComments.ModelRootDomainRoleId),
				new DomainRolePlayerInfo(typeof(ModelRootHasComments), "Comment", ModelRootHasComments.CommentDomainRoleId),
				new DomainRolePlayerInfo(typeof(ModelRootHasTypes), "ModelRoot", ModelRootHasTypes.ModelRootDomainRoleId),
				new DomainRolePlayerInfo(typeof(ModelRootHasTypes), "Type", ModelRootHasTypes.TypeDomainRoleId),
				new DomainRolePlayerInfo(typeof(CommentReferencesSubjects), "Comment", CommentReferencesSubjects.CommentDomainRoleId),
				new DomainRolePlayerInfo(typeof(CommentReferencesSubjects), "Subject", CommentReferencesSubjects.SubjectDomainRoleId),
				new DomainRolePlayerInfo(typeof(ModelHasDevices), "ModelRoot", ModelHasDevices.ModelRootDomainRoleId),
				new DomainRolePlayerInfo(typeof(ModelHasDevices), "Device", ModelHasDevices.DeviceDomainRoleId),
				new DomainRolePlayerInfo(typeof(ModelTypeReferencesActuator), "ModelType", ModelTypeReferencesActuator.ModelTypeDomainRoleId),
				new DomainRolePlayerInfo(typeof(ModelTypeReferencesActuator), "Device", ModelTypeReferencesActuator.DeviceDomainRoleId),
				new DomainRolePlayerInfo(typeof(ModelTypeReferencesSensor), "ModelType", ModelTypeReferencesSensor.ModelTypeDomainRoleId),
				new DomainRolePlayerInfo(typeof(ModelTypeReferencesSensor), "Device", ModelTypeReferencesSensor.DeviceDomainRoleId),
				new DomainRolePlayerInfo(typeof(ModelTypeReferencesFather), "SourceModelType", ModelTypeReferencesFather.SourceModelTypeDomainRoleId),
				new DomainRolePlayerInfo(typeof(ModelTypeReferencesFather), "TargetModelType", ModelTypeReferencesFather.TargetModelTypeDomainRoleId),
				new DomainRolePlayerInfo(typeof(ModelTypeReferencesBrother), "SourceModelType", ModelTypeReferencesBrother.SourceModelTypeDomainRoleId),
				new DomainRolePlayerInfo(typeof(ModelTypeReferencesBrother), "TargetModelType", ModelTypeReferencesBrother.TargetModelTypeDomainRoleId),
				new DomainRolePlayerInfo(typeof(ModelTypeReferencesAlternatives), "SourceModelType", ModelTypeReferencesAlternatives.SourceModelTypeDomainRoleId),
				new DomainRolePlayerInfo(typeof(ModelTypeReferencesAlternatives), "TargetModelType", ModelTypeReferencesAlternatives.TargetModelTypeDomainRoleId),
			};
		}
		#endregion
		#region Factory methods
		private static global::System.Collections.Generic.Dictionary<global::System.Type, int> createElementMap;
	
		/// <summary>
		/// Creates an element of specified type.
		/// </summary>
		/// <param name="partition">Partition where element is to be created.</param>
		/// <param name="elementType">Element type which belongs to this domain model.</param>
		/// <param name="propertyAssignments">New element property assignments.</param>
		/// <returns>Created element.</returns>
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1506:AvoidExcessiveClassCoupling", Justification = "Generated code.")]	
		public sealed override DslModeling::ModelElement CreateElement(DslModeling::Partition partition, global::System.Type elementType, DslModeling::PropertyAssignment[] propertyAssignments)
		{
			if (elementType == null) throw new global::System.ArgumentNullException("elementType");
	
			if (createElementMap == null)
			{
				createElementMap = new global::System.Collections.Generic.Dictionary<global::System.Type, int>(16);
				createElementMap.Add(typeof(ModelRoot), 0);
				createElementMap.Add(typeof(ModelClass), 1);
				createElementMap.Add(typeof(Comment), 2);
				createElementMap.Add(typeof(Device), 3);
				createElementMap.Add(typeof(ShHomeDiagram), 4);
				createElementMap.Add(typeof(CommentConnector), 5);
				createElementMap.Add(typeof(ActuatorConnector), 6);
				createElementMap.Add(typeof(SConnector), 7);
				createElementMap.Add(typeof(FatherConnector), 8);
				createElementMap.Add(typeof(BrotherConnector), 9);
				createElementMap.Add(typeof(AlternativesConnector), 10);
				createElementMap.Add(typeof(CommentBoxShape), 11);
				createElementMap.Add(typeof(DeviceShape), 12);
				createElementMap.Add(typeof(FShape), 13);
				createElementMap.Add(typeof(DShape), 14);
			}
			int index;
			if (!createElementMap.TryGetValue(elementType, out index))
			{
				// construct exception error message		
				string exceptionError = string.Format(
								global::System.Globalization.CultureInfo.CurrentCulture,
								global::Ufba.ShHome.ShHomeDomainModel.SingletonResourceManager.GetString("UnrecognizedElementType"),
								elementType.Name);
				throw new global::System.ArgumentException(exceptionError, "elementType");
			}
			switch (index)
			{
				case 0: return new ModelRoot(partition, propertyAssignments);
				case 1: return new ModelClass(partition, propertyAssignments);
				case 2: return new Comment(partition, propertyAssignments);
				case 3: return new Device(partition, propertyAssignments);
				case 4: return new ShHomeDiagram(partition, propertyAssignments);
				case 5: return new CommentConnector(partition, propertyAssignments);
				case 6: return new ActuatorConnector(partition, propertyAssignments);
				case 7: return new SConnector(partition, propertyAssignments);
				case 8: return new FatherConnector(partition, propertyAssignments);
				case 9: return new BrotherConnector(partition, propertyAssignments);
				case 10: return new AlternativesConnector(partition, propertyAssignments);
				case 11: return new CommentBoxShape(partition, propertyAssignments);
				case 12: return new DeviceShape(partition, propertyAssignments);
				case 13: return new FShape(partition, propertyAssignments);
				case 14: return new DShape(partition, propertyAssignments);
				default: return null;
			}
		}
	
		private static global::System.Collections.Generic.Dictionary<global::System.Type, int> createElementLinkMap;
	
		/// <summary>
		/// Creates an element link of specified type.
		/// </summary>
		/// <param name="partition">Partition where element is to be created.</param>
		/// <param name="elementLinkType">Element link type which belongs to this domain model.</param>
		/// <param name="roleAssignments">List of relationship role assignments for the new link.</param>
		/// <param name="propertyAssignments">New element property assignments.</param>
		/// <returns>Created element link.</returns>
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
		public sealed override DslModeling::ElementLink CreateElementLink(DslModeling::Partition partition, global::System.Type elementLinkType, DslModeling::RoleAssignment[] roleAssignments, DslModeling::PropertyAssignment[] propertyAssignments)
		{
			if (elementLinkType == null) throw new global::System.ArgumentNullException("elementLinkType");
			if (roleAssignments == null) throw new global::System.ArgumentNullException("roleAssignments");
	
			if (createElementLinkMap == null)
			{
				createElementLinkMap = new global::System.Collections.Generic.Dictionary<global::System.Type, int>(9);
				createElementLinkMap.Add(typeof(ModelRootHasComments), 0);
				createElementLinkMap.Add(typeof(ModelRootHasTypes), 1);
				createElementLinkMap.Add(typeof(CommentReferencesSubjects), 2);
				createElementLinkMap.Add(typeof(ModelHasDevices), 3);
				createElementLinkMap.Add(typeof(ModelTypeReferencesActuator), 4);
				createElementLinkMap.Add(typeof(ModelTypeReferencesSensor), 5);
				createElementLinkMap.Add(typeof(ModelTypeReferencesFather), 6);
				createElementLinkMap.Add(typeof(ModelTypeReferencesBrother), 7);
				createElementLinkMap.Add(typeof(ModelTypeReferencesAlternatives), 8);
			}
			int index;
			if (!createElementLinkMap.TryGetValue(elementLinkType, out index))
			{
				// construct exception error message
				string exceptionError = string.Format(
								global::System.Globalization.CultureInfo.CurrentCulture,
								global::Ufba.ShHome.ShHomeDomainModel.SingletonResourceManager.GetString("UnrecognizedElementLinkType"),
								elementLinkType.Name);
				throw new global::System.ArgumentException(exceptionError, "elementLinkType");
			
			}
			switch (index)
			{
				case 0: return new ModelRootHasComments(partition, roleAssignments, propertyAssignments);
				case 1: return new ModelRootHasTypes(partition, roleAssignments, propertyAssignments);
				case 2: return new CommentReferencesSubjects(partition, roleAssignments, propertyAssignments);
				case 3: return new ModelHasDevices(partition, roleAssignments, propertyAssignments);
				case 4: return new ModelTypeReferencesActuator(partition, roleAssignments, propertyAssignments);
				case 5: return new ModelTypeReferencesSensor(partition, roleAssignments, propertyAssignments);
				case 6: return new ModelTypeReferencesFather(partition, roleAssignments, propertyAssignments);
				case 7: return new ModelTypeReferencesBrother(partition, roleAssignments, propertyAssignments);
				case 8: return new ModelTypeReferencesAlternatives(partition, roleAssignments, propertyAssignments);
				default: return null;
			}
		}
		#endregion
		#region Resource manager
		
		private static global::System.Resources.ResourceManager resourceManager;
		
		/// <summary>
		/// The base name of this model's resources.
		/// </summary>
		public const string ResourceBaseName = "Ufba.ShHome.GeneratedCode.DomainModelResx";
		
		/// <summary>
		/// Gets the DomainModel's ResourceManager. If the ResourceManager does not already exist, then it is created.
		/// </summary>
		public override global::System.Resources.ResourceManager ResourceManager
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return ShHomeDomainModel.SingletonResourceManager;
			}
		}
	
		/// <summary>
		/// Gets the Singleton ResourceManager for this domain model.
		/// </summary>
		public static global::System.Resources.ResourceManager SingletonResourceManager
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				if (ShHomeDomainModel.resourceManager == null)
				{
					ShHomeDomainModel.resourceManager = new global::System.Resources.ResourceManager(ResourceBaseName, typeof(ShHomeDomainModel).Assembly);
				}
				return ShHomeDomainModel.resourceManager;
			}
		}
		#endregion
		#region Copy/Remove closures
		/// <summary>
		/// CopyClosure cache
		/// </summary>
		private static DslModeling::IElementVisitorFilter copyClosure;
		/// <summary>
		/// DeleteClosure cache
		/// </summary>
		private static DslModeling::IElementVisitorFilter removeClosure;
		/// <summary>
		/// Returns an IElementVisitorFilter that corresponds to the ClosureType.
		/// </summary>
		/// <param name="type">closure type</param>
		/// <param name="rootElements">collection of root elements</param>
		/// <returns>IElementVisitorFilter or null</returns>
		public override DslModeling::IElementVisitorFilter GetClosureFilter(DslModeling::ClosureType type, global::System.Collections.Generic.ICollection<DslModeling::ModelElement> rootElements)
		{
			switch (type)
			{
				case DslModeling::ClosureType.CopyClosure:
					return ShHomeDomainModel.CopyClosure;
				case DslModeling::ClosureType.DeleteClosure:
					return ShHomeDomainModel.DeleteClosure;
			}
			return base.GetClosureFilter(type, rootElements);
		}
		/// <summary>
		/// CopyClosure cache
		/// </summary>
		private static DslModeling::IElementVisitorFilter CopyClosure
		{
			get
			{
				// Incorporate all of the closures from the models we extend
				if (ShHomeDomainModel.copyClosure == null)
				{
					DslModeling::ChainingElementVisitorFilter copyFilter = new DslModeling::ChainingElementVisitorFilter();
					copyFilter.AddFilter(new ShHomeCopyClosure());
					copyFilter.AddFilter(new DslModeling::CoreCopyClosure());
					copyFilter.AddFilter(new DslDiagrams::CoreDesignSurfaceCopyClosure());
					
					ShHomeDomainModel.copyClosure = copyFilter;
				}
				return ShHomeDomainModel.copyClosure;
			}
		}
		/// <summary>
		/// DeleteClosure cache
		/// </summary>
		private static DslModeling::IElementVisitorFilter DeleteClosure
		{
			get
			{
				// Incorporate all of the closures from the models we extend
				if (ShHomeDomainModel.removeClosure == null)
				{
					DslModeling::ChainingElementVisitorFilter removeFilter = new DslModeling::ChainingElementVisitorFilter();
					removeFilter.AddFilter(new ShHomeDeleteClosure());
					removeFilter.AddFilter(new DslModeling::CoreDeleteClosure());
					removeFilter.AddFilter(new DslDiagrams::CoreDesignSurfaceDeleteClosure());
		
					ShHomeDomainModel.removeClosure = removeFilter;
				}
				return ShHomeDomainModel.removeClosure;
			}
		}
		#endregion
		#region Diagram rule helpers
		/// <summary>
		/// Enables rules in this domain model related to diagram fixup for the given store.
		/// If diagram data will be loaded into the store, this method should be called first to ensure
		/// that the diagram behaves properly.
		/// </summary>
		public static void EnableDiagramRules(DslModeling::Store store)
		{
			if(store == null) throw new global::System.ArgumentNullException("store");
			
			DslModeling::RuleManager ruleManager = store.RuleManager;
			ruleManager.EnableRule(typeof(global::Ufba.ShHome.FixUpDiagram));
			ruleManager.EnableRule(typeof(global::Ufba.ShHome.ConnectorRolePlayerChanged));
		}
		
		/// <summary>
		/// Disables rules in this domain model related to diagram fixup for the given store.
		/// </summary>
		public static void DisableDiagramRules(DslModeling::Store store)
		{
			if(store == null) throw new global::System.ArgumentNullException("store");
			
			DslModeling::RuleManager ruleManager = store.RuleManager;
			ruleManager.DisableRule(typeof(global::Ufba.ShHome.FixUpDiagram));
			ruleManager.DisableRule(typeof(global::Ufba.ShHome.ConnectorRolePlayerChanged));
		}
		#endregion
	}
		
	#region Copy/Remove closure classes
	/// <summary>
	/// Remove closure visitor filter
	/// </summary>
	[global::System.CLSCompliant(true)]
	public partial class ShHomeDeleteClosure : ShHomeDeleteClosureBase, DslModeling::IElementVisitorFilter
	{
		/// <summary>
		/// Constructor
		/// </summary>
		public ShHomeDeleteClosure() : base()
		{
		}
	}
	
	/// <summary>
	/// Base class for remove closure visitor filter
	/// </summary>
	[global::System.CLSCompliant(true)]
	public partial class ShHomeDeleteClosureBase : DslModeling::IElementVisitorFilter
	{
		/// <summary>
		/// DomainRoles
		/// </summary>
		private global::System.Collections.Specialized.HybridDictionary domainRoles;
		/// <summary>
		/// Constructor
		/// </summary>
		public ShHomeDeleteClosureBase()
		{
			#region Initialize DomainData Table
			DomainRoles.Add(global::Ufba.ShHome.ModelRootHasComments.CommentDomainRoleId, true);
			DomainRoles.Add(global::Ufba.ShHome.ModelRootHasTypes.TypeDomainRoleId, true);
			DomainRoles.Add(global::Ufba.ShHome.ModelHasDevices.DeviceDomainRoleId, true);
			#endregion
		}
		/// <summary>
		/// Called to ask the filter if a particular relationship from a source element should be included in the traversal
		/// </summary>
		/// <param name="walker">ElementWalker that is traversing the model</param>
		/// <param name="sourceElement">Model Element playing the source role</param>
		/// <param name="sourceRoleInfo">DomainRoleInfo of the role that the source element is playing in the relationship</param>
		/// <param name="domainRelationshipInfo">DomainRelationshipInfo for the ElementLink in question</param>
		/// <param name="targetRelationship">Relationship in question</param>
		/// <returns>Yes if the relationship should be traversed</returns>
		public virtual DslModeling::VisitorFilterResult ShouldVisitRelationship(DslModeling::ElementWalker walker, DslModeling::ModelElement sourceElement, DslModeling::DomainRoleInfo sourceRoleInfo, DslModeling::DomainRelationshipInfo domainRelationshipInfo, DslModeling::ElementLink targetRelationship)
		{
			return DslModeling::VisitorFilterResult.Yes;
		}
		/// <summary>
		/// Called to ask the filter if a particular role player should be Visited during traversal
		/// </summary>
		/// <param name="walker">ElementWalker that is traversing the model</param>
		/// <param name="sourceElement">Model Element playing the source role</param>
		/// <param name="elementLink">Element Link that forms the relationship to the role player in question</param>
		/// <param name="targetDomainRole">DomainRoleInfo of the target role</param>
		/// <param name="targetRolePlayer">Model Element that plays the target role in the relationship</param>
		/// <returns></returns>
		public virtual DslModeling::VisitorFilterResult ShouldVisitRolePlayer(DslModeling::ElementWalker walker, DslModeling::ModelElement sourceElement, DslModeling::ElementLink elementLink, DslModeling::DomainRoleInfo targetDomainRole, DslModeling::ModelElement targetRolePlayer)
		{
			if (targetDomainRole == null) throw new global::System.ArgumentNullException("targetDomainRole");
			return this.DomainRoles.Contains(targetDomainRole.Id) ? DslModeling::VisitorFilterResult.Yes : DslModeling::VisitorFilterResult.DoNotCare;
		}
		/// <summary>
		/// DomainRoles
		/// </summary>
		private global::System.Collections.Specialized.HybridDictionary DomainRoles
		{
			get
			{
				if (this.domainRoles == null)
				{
					this.domainRoles = new global::System.Collections.Specialized.HybridDictionary();
				}
				return this.domainRoles;
			}
		}
	
	}
	/// <summary>
	/// Copy closure visitor filter
	/// </summary>
	[global::System.CLSCompliant(true)]
	public partial class ShHomeCopyClosure : ShHomeCopyClosureBase, DslModeling::IElementVisitorFilter
	{
		/// <summary>
		/// Constructor
		/// </summary>
		public ShHomeCopyClosure() : base()
		{
		}
	}
	/// <summary>
	/// Base class for copy closure visitor filter
	/// </summary>
	[global::System.CLSCompliant(true)]
	public partial class ShHomeCopyClosureBase : DslModeling::CopyClosureFilter, DslModeling::IElementVisitorFilter
	{
		/// <summary>
		/// Constructor
		/// </summary>
		public ShHomeCopyClosureBase():base()
		{
		}
	}
	#endregion
		
}
namespace Ufba.ShHome
{
	/// <summary>
	/// DomainEnumeration: AccessModifier
	/// </summary>
	[global::System.CLSCompliant(true)]
	public enum AccessModifier
	{
		/// <summary>
		/// Public
		/// </summary>
		[DslDesign::DescriptionResource("Ufba.ShHome.AccessModifier/Public.Description", typeof(global::Ufba.ShHome.ShHomeDomainModel), "Ufba.ShHome.GeneratedCode.DomainModelResx")]
		Public = 0,
		/// <summary>
		/// Assembly
		/// </summary>
		[DslDesign::DescriptionResource("Ufba.ShHome.AccessModifier/Assembly.Description", typeof(global::Ufba.ShHome.ShHomeDomainModel), "Ufba.ShHome.GeneratedCode.DomainModelResx")]
		Assembly = 1,
		/// <summary>
		/// Private
		/// </summary>
		[DslDesign::DescriptionResource("Ufba.ShHome.AccessModifier/Private.Description", typeof(global::Ufba.ShHome.ShHomeDomainModel), "Ufba.ShHome.GeneratedCode.DomainModelResx")]
		Private = 2,
		/// <summary>
		/// Family
		/// </summary>
		[DslDesign::DescriptionResource("Ufba.ShHome.AccessModifier/Family.Description", typeof(global::Ufba.ShHome.ShHomeDomainModel), "Ufba.ShHome.GeneratedCode.DomainModelResx")]
		Family = 3,
		/// <summary>
		/// FamilyOrAssembly
		/// </summary>
		[DslDesign::DescriptionResource("Ufba.ShHome.AccessModifier/FamilyOrAssembly.Description", typeof(global::Ufba.ShHome.ShHomeDomainModel), "Ufba.ShHome.GeneratedCode.DomainModelResx")]
		FamilyOrAssembly = 4,
		/// <summary>
		/// FamilyAndAssembly
		/// </summary>
		[DslDesign::DescriptionResource("Ufba.ShHome.AccessModifier/FamilyAndAssembly.Description", typeof(global::Ufba.ShHome.ShHomeDomainModel), "Ufba.ShHome.GeneratedCode.DomainModelResx")]
		FamilyAndAssembly = 5,
	}
}
namespace Ufba.ShHome
{
	/// <summary>
	/// DomainEnumeration: TypeAccessModifier
	/// </summary>
	[global::System.CLSCompliant(true)]
	public enum TypeAccessModifier
	{
		/// <summary>
		/// Public
		/// </summary>
		[DslDesign::DescriptionResource("Ufba.ShHome.TypeAccessModifier/Public.Description", typeof(global::Ufba.ShHome.ShHomeDomainModel), "Ufba.ShHome.GeneratedCode.DomainModelResx")]
		Public = 0,
		/// <summary>
		/// Private
		/// </summary>
		[DslDesign::DescriptionResource("Ufba.ShHome.TypeAccessModifier/Private.Description", typeof(global::Ufba.ShHome.ShHomeDomainModel), "Ufba.ShHome.GeneratedCode.DomainModelResx")]
		Private = 1,
	}
}
namespace Ufba.ShHome
{
	/// <summary>
	/// DomainEnumeration: InheritanceModifier
	/// </summary>
	[global::System.CLSCompliant(true)]
	public enum InheritanceModifier
	{
		/// <summary>
		/// None
		/// </summary>
		[DslDesign::DescriptionResource("Ufba.ShHome.InheritanceModifier/None.Description", typeof(global::Ufba.ShHome.ShHomeDomainModel), "Ufba.ShHome.GeneratedCode.DomainModelResx")]
		None = 0,
		/// <summary>
		/// Abstract
		/// </summary>
		[DslDesign::DescriptionResource("Ufba.ShHome.InheritanceModifier/Abstract.Description", typeof(global::Ufba.ShHome.ShHomeDomainModel), "Ufba.ShHome.GeneratedCode.DomainModelResx")]
		Abstract = 1,
		/// <summary>
		/// Sealed
		/// </summary>
		[DslDesign::DescriptionResource("Ufba.ShHome.InheritanceModifier/Sealed.Description", typeof(global::Ufba.ShHome.ShHomeDomainModel), "Ufba.ShHome.GeneratedCode.DomainModelResx")]
		Sealed = 2,
	}
}
namespace Ufba.ShHome
{
	/// <summary>
	/// DomainEnumeration: Multiplicity
	/// </summary>
	[global::System.CLSCompliant(true)]
	public enum Multiplicity
	{
		/// <summary>
		/// ZeroMany
		/// </summary>
		[DslDesign::DescriptionResource("Ufba.ShHome.Multiplicity/ZeroMany.Description", typeof(global::Ufba.ShHome.ShHomeDomainModel), "Ufba.ShHome.GeneratedCode.DomainModelResx")]
		ZeroMany = 0,
		/// <summary>
		/// One
		/// </summary>
		[DslDesign::DescriptionResource("Ufba.ShHome.Multiplicity/One.Description", typeof(global::Ufba.ShHome.ShHomeDomainModel), "Ufba.ShHome.GeneratedCode.DomainModelResx")]
		One = 1,
		/// <summary>
		/// ZeroOne
		/// </summary>
		[DslDesign::DescriptionResource("Ufba.ShHome.Multiplicity/ZeroOne.Description", typeof(global::Ufba.ShHome.ShHomeDomainModel), "Ufba.ShHome.GeneratedCode.DomainModelResx")]
		ZeroOne = 2,
		/// <summary>
		/// OneMany
		/// </summary>
		[DslDesign::DescriptionResource("Ufba.ShHome.Multiplicity/OneMany.Description", typeof(global::Ufba.ShHome.ShHomeDomainModel), "Ufba.ShHome.GeneratedCode.DomainModelResx")]
		OneMany = 3,
	}
}
namespace Ufba.ShHome
{
	/// <summary>
	/// DomainEnumeration: OperationConcurrency
	/// </summary>
	[global::System.CLSCompliant(true)]
	public enum OperationConcurrency
	{
		/// <summary>
		/// Sequential
		/// </summary>
		[DslDesign::DescriptionResource("Ufba.ShHome.OperationConcurrency/Sequential.Description", typeof(global::Ufba.ShHome.ShHomeDomainModel), "Ufba.ShHome.GeneratedCode.DomainModelResx")]
		Sequential = 0,
		/// <summary>
		/// Guarded
		/// </summary>
		[DslDesign::DescriptionResource("Ufba.ShHome.OperationConcurrency/Guarded.Description", typeof(global::Ufba.ShHome.ShHomeDomainModel), "Ufba.ShHome.GeneratedCode.DomainModelResx")]
		Guarded = 1,
		/// <summary>
		/// Concurrent
		/// </summary>
		[DslDesign::DescriptionResource("Ufba.ShHome.OperationConcurrency/Concurrent.Description", typeof(global::Ufba.ShHome.ShHomeDomainModel), "Ufba.ShHome.GeneratedCode.DomainModelResx")]
		Concurrent = 2,
	}
}
namespace Ufba.ShHome
{
	/// <summary>
	/// DomainEnumeration: TypeFeature
	/// Description for Ufba.ShHome.TypeFeature
	/// </summary>
	[global::System.CLSCompliant(true)]
	public enum TypeFeature
	{
		/// <summary>
		/// Mandatory
		/// Description for Ufba.ShHome.TypeFeature.Mandatory
		/// </summary>
		[DslDesign::DescriptionResource("Ufba.ShHome.TypeFeature/Mandatory.Description", typeof(global::Ufba.ShHome.ShHomeDomainModel), "Ufba.ShHome.GeneratedCode.DomainModelResx")]
		Mandatory,
		/// <summary>
		/// EnumerationLiteral2
		/// Description for Ufba.ShHome.TypeFeature.EnumerationLiteral2
		/// </summary>
		[DslDesign::DescriptionResource("Ufba.ShHome.TypeFeature/EnumerationLiteral2.Description", typeof(global::Ufba.ShHome.ShHomeDomainModel), "Ufba.ShHome.GeneratedCode.DomainModelResx")]
		EnumerationLiteral2,
		/// <summary>
		/// OR
		/// Description for Ufba.ShHome.TypeFeature.OR
		/// </summary>
		[DslDesign::DescriptionResource("Ufba.ShHome.TypeFeature/OR.Description", typeof(global::Ufba.ShHome.ShHomeDomainModel), "Ufba.ShHome.GeneratedCode.DomainModelResx")]
		OR,
		/// <summary>
		/// Optional
		/// Description for Ufba.ShHome.TypeFeature.Optional
		/// </summary>
		[DslDesign::DescriptionResource("Ufba.ShHome.TypeFeature/Optional.Description", typeof(global::Ufba.ShHome.ShHomeDomainModel), "Ufba.ShHome.GeneratedCode.DomainModelResx")]
		Optional,
		/// <summary>
		/// Alternative
		/// Description for Ufba.ShHome.TypeFeature.Alternative
		/// </summary>
		[DslDesign::DescriptionResource("Ufba.ShHome.TypeFeature/Alternative.Description", typeof(global::Ufba.ShHome.ShHomeDomainModel), "Ufba.ShHome.GeneratedCode.DomainModelResx")]
		Alternative,
	}
}
namespace Ufba.ShHome
{
	/// <summary>
	/// DomainEnumeration: TypeDevice
	/// Description for Ufba.ShHome.TypeDevice
	/// </summary>
	[global::System.CLSCompliant(true)]
	public enum TypeDevice
	{
		/// <summary>
		/// Actuator
		/// Description for Ufba.ShHome.TypeDevice.Actuator
		/// </summary>
		[DslDesign::DescriptionResource("Ufba.ShHome.TypeDevice/Actuator.Description", typeof(global::Ufba.ShHome.ShHomeDomainModel), "Ufba.ShHome.GeneratedCode.DomainModelResx")]
		Actuator,
		/// <summary>
		/// Sensor
		/// Description for Ufba.ShHome.TypeDevice.Sensor
		/// </summary>
		[DslDesign::DescriptionResource("Ufba.ShHome.TypeDevice/Sensor.Description", typeof(global::Ufba.ShHome.ShHomeDomainModel), "Ufba.ShHome.GeneratedCode.DomainModelResx")]
		Sensor,
	}
}
namespace Ufba.ShHome
{
	/// <summary>
	/// DomainEnumeration: NameFeature
	/// Description for Ufba.ShHome.NameFeature
	/// </summary>
	[global::System.CLSCompliant(true)]
	public enum NameFeature
	{
		/// <summary>
		/// UserAirConditionerControl
		/// Description for Ufba.ShHome.NameFeature.UserAirConditionerControl
		/// </summary>
		[DslDesign::DescriptionResource("Ufba.ShHome.NameFeature/UserAirConditionerControl.Description", typeof(global::Ufba.ShHome.ShHomeDomainModel), "Ufba.ShHome.GeneratedCode.DomainModelResx")]
		UserAirConditionerControl,
		/// <summary>
		/// PresenceIlusion
		/// Description for Ufba.ShHome.NameFeature.PresenceIlusion
		/// </summary>
		[DslDesign::DescriptionResource("Ufba.ShHome.NameFeature/PresenceIlusion.Description", typeof(global::Ufba.ShHome.ShHomeDomainModel), "Ufba.ShHome.GeneratedCode.DomainModelResx")]
		PresenceIlusion,
		/// <summary>
		/// UserWindowControl
		/// Description for Ufba.ShHome.NameFeature.UserWindowControl
		/// </summary>
		[DslDesign::DescriptionResource("Ufba.ShHome.NameFeature/UserWindowControl.Description", typeof(global::Ufba.ShHome.ShHomeDomainModel), "Ufba.ShHome.GeneratedCode.DomainModelResx")]
		UserWindowControl,
		/// <summary>
		/// AutomatedWindowControl
		/// Description for Ufba.ShHome.NameFeature.AutomatedWindowControl
		/// </summary>
		[DslDesign::DescriptionResource("Ufba.ShHome.NameFeature/AutomatedWindowControl.Description", typeof(global::Ufba.ShHome.ShHomeDomainModel), "Ufba.ShHome.GeneratedCode.DomainModelResx")]
		AutomatedWindowControl,
		/// <summary>
		/// AutomatedIluminationByLuminosity
		/// Description for Ufba.ShHome.NameFeature.AutomatedIluminationByLuminosity
		/// </summary>
		[DslDesign::DescriptionResource("Ufba.ShHome.NameFeature/AutomatedIluminationByLuminosity.Description", typeof(global::Ufba.ShHome.ShHomeDomainModel), "Ufba.ShHome.GeneratedCode.DomainModelResx")]
		AutomatedIluminationByLuminosity,
		/// <summary>
		/// UserIlumination
		/// Description for Ufba.ShHome.NameFeature.UserIlumination
		/// </summary>
		[DslDesign::DescriptionResource("Ufba.ShHome.NameFeature/UserIlumination.Description", typeof(global::Ufba.ShHome.ShHomeDomainModel), "Ufba.ShHome.GeneratedCode.DomainModelResx")]
		UserIlumination,
		/// <summary>
		/// AutomatedIluminationByPresence
		/// Description for Ufba.ShHome.NameFeature.AutomatedIluminationByPresence
		/// </summary>
		[DslDesign::DescriptionResource("Ufba.ShHome.NameFeature/AutomatedIluminationByPresence.Description", typeof(global::Ufba.ShHome.ShHomeDomainModel), "Ufba.ShHome.GeneratedCode.DomainModelResx")]
		AutomatedIluminationByPresence,
		/// <summary>
		/// AutomatedAirConditionerControl
		/// Description for Ufba.ShHome.NameFeature.AutomatedAirConditionerControl
		/// </summary>
		[DslDesign::DescriptionResource("Ufba.ShHome.NameFeature/AutomatedAirConditionerControl.Description", typeof(global::Ufba.ShHome.ShHomeDomainModel), "Ufba.ShHome.GeneratedCode.DomainModelResx")]
		AutomatedAirConditionerControl,
		/// <summary>
		/// LockDoors
		/// Description for Ufba.ShHome.NameFeature.LockDoors
		/// </summary>
		[DslDesign::DescriptionResource("Ufba.ShHome.NameFeature/LockDoors.Description", typeof(global::Ufba.ShHome.ShHomeDomainModel), "Ufba.ShHome.GeneratedCode.DomainModelResx")]
		LockDoors,
		/// <summary>
		/// AlarmAgainstRobbery
		/// Description for Ufba.ShHome.NameFeature.AlarmAgainstRobbery
		/// </summary>
		[DslDesign::DescriptionResource("Ufba.ShHome.NameFeature/AlarmAgainstRobbery.Description", typeof(global::Ufba.ShHome.ShHomeDomainModel), "Ufba.ShHome.GeneratedCode.DomainModelResx")]
		AlarmAgainstRobbery,
		/// <summary>
		/// PanicMode
		/// Description for Ufba.ShHome.NameFeature.PanicMode
		/// </summary>
		[DslDesign::DescriptionResource("Ufba.ShHome.NameFeature/PanicMode.Description", typeof(global::Ufba.ShHome.ShHomeDomainModel), "Ufba.ShHome.GeneratedCode.DomainModelResx")]
		PanicMode,
	}
}
namespace Ufba.ShHome
{
	/// <summary>
	/// DomainEnumeration: ReturnType
	/// Description for Ufba.ShHome.ReturnType
	/// </summary>
	[global::System.CLSCompliant(true)]
	public enum ReturnType
	{
		/// <summary>
		/// BOOL
		/// Description for Ufba.ShHome.ReturnType.BOOL
		/// </summary>
		[DslDesign::DescriptionResource("Ufba.ShHome.ReturnType/BOOL.Description", typeof(global::Ufba.ShHome.ShHomeDomainModel), "Ufba.ShHome.GeneratedCode.DomainModelResx")]
		BOOL,
		/// <summary>
		/// RANGE
		/// Description for Ufba.ShHome.ReturnType.RANGE
		/// </summary>
		[DslDesign::DescriptionResource("Ufba.ShHome.ReturnType/RANGE.Description", typeof(global::Ufba.ShHome.ShHomeDomainModel), "Ufba.ShHome.GeneratedCode.DomainModelResx")]
		RANGE,
		/// <summary>
		/// INFO
		/// Description for Ufba.ShHome.ReturnType.INFO
		/// </summary>
		[DslDesign::DescriptionResource("Ufba.ShHome.ReturnType/INFO.Description", typeof(global::Ufba.ShHome.ShHomeDomainModel), "Ufba.ShHome.GeneratedCode.DomainModelResx")]
		INFO,
	}
}

