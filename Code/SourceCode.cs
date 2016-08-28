namespace generators {
    
    
    public class court_member_introduced : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			UnityEngine.Debug.Log(root);
			
			
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar3 = default(System.Boolean); //IsContext = False IsNew = False
			World StoredVariable0 = root.GetComponent<World>(); //IsContext = False IsNew = False
			if(StoredVariable0 != null)
			{
				
				System.Collections.Generic.List<UnityEngine.GameObject> OperandVar2 = default(System.Collections.Generic.List<UnityEngine.GameObject>); //IsContext = False IsNew = False
				System.Collections.Generic.List<UnityEngine.GameObject> prop1 = StoredVariable0.Objects; //IsContext = False IsNew = False
				if(prop1 != null)
				{
					OperandVar2 = prop1;
				} else { UnityEngine.Debug.Log("prop1 != null = false " ); }
				
				
				if(( ( (OperandVar2 != null ? OperandVar2.Count : 0))) == ( ( (0f))))
				{
					applicable = true;
					OperandVar3 = applicable;
				} else { UnityEngine.Debug.Log("( ( (OperandVar2 != null ? OperandVar2.Count : 0))) == ( ( (0f))) = false " ); }
			} else { UnityEngine.Debug.Log("StoredVariable0 != null = false " ); }
			return (System.Boolean) (OperandVar3);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			UnityEngine.Debug.Log(root);
			
			
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			UnityEngine.Debug.Log(root);
			
			
			
			
			{
				World subContext4 = root.GetComponent<World>(); //IsContext = True IsNew = False
				
				if(subContext4 != null)
				{
					
					for (int i = 0; i <  (5f); i++)
					{
						UnityEngine.GameObject court_member = new UnityEngine.GameObject("court_member"); //IsContext = False IsNew = False
						
						{
							UnityEngine.GameObject court_member5 = court_member; //IsContext = True IsNew = False
							Entity AddContext6 = court_member.AddComponent<Entity>(); //IsContext = True IsNew = True
							
							{
								
								if(AddContext6 != null)
								{
									GODelegate Lambda7 = (UnityEngine.GameObject entity) => 
									{
										
										UnityEngine.GameObject OperandVar8 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
										OperandVar8 = entity;
										subContext4.Detach( (OperandVar8));
									};
									AddContext6.OnDestruction(Lambda7);
								} else { UnityEngine.Debug.Log("AddContext6 != null = false " ); }
							}
							Actor AddContext9 = court_member.AddComponent<Actor>(); //IsContext = True IsNew = True
							
							{
								
								if(AddContext9 != null)
								{
									
									
									
									System.Single OperandVar11 = default(System.Single); //IsContext = False IsNew = False
									
									
									System.Single prop10 = External.Random( (0f), (1000000f)); //IsContext = False IsNew = False
									OperandVar11 = prop10;
									AddContext9.Name = ( ( ("Courtier"))) + ( ( (OperandVar11)));
								} else { UnityEngine.Debug.Log("AddContext9 != null = false " ); }
							}
							Traits AddContext12 = court_member.AddComponent<Traits>(); //IsContext = True IsNew = True
						}
						UnityEngine.Object.FindObjectOfType<Generators>().Generate(court_member);
						UnityEngine.GameObject OperandVar13 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
						OperandVar13 = court_member;
						subContext4.Attach( (OperandVar13));
					}
				} else { UnityEngine.Debug.Log("subContext4 != null = false " ); }
			}
		}
        }
    }
    
    public class events_data_added : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			UnityEngine.Debug.Log(root);
			
			
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar19 = default(System.Boolean); //IsContext = False IsNew = False
			World StoredVariable14 = root.GetComponent<World>(); //IsContext = False IsNew = False
			if(StoredVariable14 != null)
			{
				System.Boolean OperandVar18 = default(System.Boolean); //IsContext = False IsNew = False
				Blackboards.events_data OperandVar16 = default(Blackboards.events_data); //IsContext = False IsNew = False
				Blackboards.events_data StoredVariable15 = StoredVariable14.GetComponent<Blackboards.events_data>(); //IsContext = False IsNew = False
				if(StoredVariable15 != null)
				{
					OperandVar16 = StoredVariable15;
				} else { UnityEngine.Debug.Log("StoredVariable15 != null = false " ); }
				System.Boolean prop17 = External.Has( (OperandVar16)); //IsContext = False IsNew = False
				OperandVar18 = prop17;
				if(!(OperandVar18))
				{
					applicable = true;
					OperandVar19 = applicable;
				} else { UnityEngine.Debug.Log("!(OperandVar18) = false " ); }
			} else { UnityEngine.Debug.Log("StoredVariable14 != null = false " ); }
			return (System.Boolean) (OperandVar19);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			UnityEngine.Debug.Log(root);
			
			
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			UnityEngine.Debug.Log(root);
			
			
			
			root.AddComponent<Blackboards.events_data>();
		}
        }
    }
    
    public class personality_added : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			UnityEngine.Debug.Log(root);
			
			
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar25 = default(System.Boolean); //IsContext = False IsNew = False
			Actor StoredVariable20 = root.GetComponent<Actor>(); //IsContext = False IsNew = False
			if(StoredVariable20 != null)
			{
				System.Boolean OperandVar24 = default(System.Boolean); //IsContext = False IsNew = False
				Blackboards.personality OperandVar22 = default(Blackboards.personality); //IsContext = False IsNew = False
				Blackboards.personality StoredVariable21 = StoredVariable20.GetComponent<Blackboards.personality>(); //IsContext = False IsNew = False
				if(StoredVariable21 != null)
				{
					OperandVar22 = StoredVariable21;
				} else { UnityEngine.Debug.Log("StoredVariable21 != null = false " ); }
				System.Boolean prop23 = External.Has( (OperandVar22)); //IsContext = False IsNew = False
				OperandVar24 = prop23;
				if(!(OperandVar24))
				{
					applicable = true;
					OperandVar25 = applicable;
				} else { UnityEngine.Debug.Log("!(OperandVar24) = false " ); }
			} else { UnityEngine.Debug.Log("StoredVariable20 != null = false " ); }
			return (System.Boolean) (OperandVar25);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			UnityEngine.Debug.Log(root);
			
			
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			UnityEngine.Debug.Log(root);
			
			
			
			Blackboards.personality ContextVar26 = root.AddComponent<Blackboards.personality>();; //IsContext = False IsNew = True
			
			{
				
				if(ContextVar26 != null)
				{
					System.Single OperandVar28 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop27 = External.Random( (0.4f), (1f)); //IsContext = False IsNew = False
					OperandVar28 = prop27;
					ContextVar26.Cruelty =  (OperandVar28);
					System.Single OperandVar30 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop29 = External.Random( (0f), (1f)); //IsContext = False IsNew = False
					OperandVar30 = prop29;
					ContextVar26.Rationality =  (OperandVar30);
					System.Single OperandVar32 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop31 = External.Random( (0f), (1f)); //IsContext = False IsNew = False
					OperandVar32 = prop31;
					ContextVar26.Generosity =  (OperandVar32);
					System.Single OperandVar34 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop33 = External.Random( (0.4f), (1f)); //IsContext = False IsNew = False
					OperandVar34 = prop33;
					ContextVar26.Zealotry =  (OperandVar34);
				} else { UnityEngine.Debug.Log("ContextVar26 != null = false " ); }
			}
		}
        }
    }
    
    public class burn_the_wizard : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			UnityEngine.Debug.Log(root);
			
			
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar43 = default(System.Boolean); //IsContext = False IsNew = False
			Actor StoredVariable35 = root.GetComponent<Actor>(); //IsContext = False IsNew = False
			if(StoredVariable35 != null)
			{
				Blackboards.personality StoredVariable36 = StoredVariable35.GetComponent<Blackboards.personality>(); //IsContext = False IsNew = False
				if(StoredVariable36 != null)
				{
					
					
					System.Single OperandVar38 = default(System.Single); //IsContext = False IsNew = False
					System.Single prop37 = StoredVariable36.Cruelty; //IsContext = False IsNew = False
					OperandVar38 = prop37;
					
					
					
					
					System.Single OperandVar40 = default(System.Single); //IsContext = False IsNew = False
					if(StoredVariable36 != null)
					{
						System.Single prop39 = StoredVariable36.Rationality; //IsContext = False IsNew = False
						OperandVar40 = prop39;
					} else { UnityEngine.Debug.Log("StoredVariable36 != null = false " ); }
					
					
					
					
					System.Single OperandVar42 = default(System.Single); //IsContext = False IsNew = False
					if(StoredVariable36 != null)
					{
						System.Single prop41 = StoredVariable36.Zealotry; //IsContext = False IsNew = False
						OperandVar42 = prop41;
					} else { UnityEngine.Debug.Log("StoredVariable36 != null = false " ); }
					
					
					if(( (( ( (OperandVar38))) > ( ( (0.5f))))) && ( (( ( (OperandVar40))) < ( ( (0.5f))))) && ( (( ( (OperandVar42))) > ( ( (0.5f))))))
					{
						applicable = true;
						OperandVar43 = applicable;
					} else { UnityEngine.Debug.Log("( (( ( (OperandVar38))) > ( ( (0.5f))))) && ( (( ( (OperandVar40))) < ( ( (0.5f))))) && ( (( ( (OperandVar42))) > ( ( (0.5f))))) = false " ); }
				} else { UnityEngine.Debug.Log("StoredVariable36 != null = false " ); }
			} else { UnityEngine.Debug.Log("StoredVariable35 != null = false " ); }
			return (System.Boolean) (OperandVar43);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			UnityEngine.Debug.Log(root);
			
			
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			{
				World FuncCtx44 = External.GetWorld();; //IsContext = True IsNew = False
				
				if(FuncCtx44 != null)
				{
					
					{
						Blackboards.events_data subContext45 = FuncCtx44.GetComponent<Blackboards.events_data>(); //IsContext = True IsNew = False
						
						if(subContext45 != null)
						{
							System.Boolean OperandVar49 = default(System.Boolean); //IsContext = False IsNew = False
							UnityEngine.GameObject OperandVar47 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
							UnityEngine.GameObject prop46 = subContext45.Wizard; //IsContext = False IsNew = False
							if(prop46 != null)
							{
								OperandVar47 = prop46;
							} else { UnityEngine.Debug.Log("prop46 != null = false " ); }
							System.Boolean prop48 = External.Has( (OperandVar47)); //IsContext = False IsNew = False
							OperandVar49 = prop48;
							if(!(OperandVar49))
							{
								UnityEngine.GameObject OperandVar58 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
								System.Collections.Generic.List<UnityEngine.GameObject> OperandVar51 = default(System.Collections.Generic.List<UnityEngine.GameObject>); //IsContext = False IsNew = False
								if(FuncCtx44 != null)
								{
									System.Collections.Generic.List<UnityEngine.GameObject> prop50 = FuncCtx44.Objects; //IsContext = False IsNew = False
									if(prop50 != null)
									{
										OperandVar51 = prop50;
									} else { UnityEngine.Debug.Log("prop50 != null = false " ); }
								} else { UnityEngine.Debug.Log("FuncCtx44 != null = false " ); }
								UnityEngine.GameObject prop57 = External.SelectFrom( (OperandVar51),(UnityEngine.GameObject go)=>{;
;
;
System.Single OperandVar54 = default(System.Single); //IsContext = False IsNew = False;
Blackboards.personality StoredVariable52 = go.GetComponent<Blackboards.personality>(); //IsContext = False IsNew = False;
if(StoredVariable52 != null)
									{
										System.Single prop53 = StoredVariable52.Rationality; //IsContext = False IsNew = False
										OperandVar54 = prop53;
									} else { UnityEngine.Debug.Log("StoredVariable52 != null = false " ); };
;
;
;
;
;
UnityEngine.GameObject OperandVar55 = default(UnityEngine.GameObject); //IsContext = False IsNew = False;
OperandVar55 = go;;
;
UnityEngine.GameObject OperandVar56 = default(UnityEngine.GameObject); //IsContext = False IsNew = False;
OperandVar56 = root;;
return ( (( ( (OperandVar54))) > ( ( (0.7f))))) && ( (!(( ( (OperandVar55))) == ( ( (OperandVar56))))));}); //IsContext = False IsNew = False
								if(prop57 != null)
								{
									OperandVar58 = prop57;
								} else { UnityEngine.Debug.Log("prop57 != null = false " ); }
								subContext45.Wizard =  (OperandVar58);
							} else { UnityEngine.Debug.Log("!(OperandVar49) = false " ); }
							
							System.Boolean OperandVar62 = default(System.Boolean); //IsContext = False IsNew = False
							UnityEngine.GameObject OperandVar60 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
							UnityEngine.GameObject prop59 = subContext45.Wizard; //IsContext = False IsNew = False
							if(prop59 != null)
							{
								OperandVar60 = prop59;
							} else { UnityEngine.Debug.Log("prop59 != null = false " ); }
							System.Boolean prop61 = External.Has( (OperandVar60)); //IsContext = False IsNew = False
							OperandVar62 = prop61;
							
							System.Boolean OperandVar64 = default(System.Boolean); //IsContext = False IsNew = False
							if(subContext45 != null)
							{
								System.Boolean prop63 = subContext45.WizardBurned; //IsContext = False IsNew = False
								OperandVar64 = prop63;
							} else { UnityEngine.Debug.Log("subContext45 != null = false " ); }
							if(( ( (OperandVar62))) && ( (!(OperandVar64))))
							{
								
								System.Single OperandVar67 = default(System.Single); //IsContext = False IsNew = False
								Blackboards.personality StoredVariable65 = root.GetComponent<Blackboards.personality>(); //IsContext = False IsNew = False
								if(StoredVariable65 != null)
								{
									System.Single prop66 = StoredVariable65.Cruelty; //IsContext = False IsNew = False
									OperandVar67 = prop66;
								} else { UnityEngine.Debug.Log("StoredVariable65 != null = false " ); }
								
								
								System.Single OperandVar69 = default(System.Single); //IsContext = False IsNew = False
								if(StoredVariable65 != null)
								{
									System.Single prop68 = StoredVariable65.Zealotry; //IsContext = False IsNew = False
									OperandVar69 = prop68;
								} else { UnityEngine.Debug.Log("StoredVariable65 != null = false " ); }
								
								
								System.Single OperandVar72 = default(System.Single); //IsContext = False IsNew = False
								if(subContext45 != null)
								{
									UnityEngine.GameObject prop70 = subContext45.Wizard; //IsContext = False IsNew = False
									if(prop70 != null)
									{
										if(StoredVariable65 != null)
										{
											System.Single prop71 = StoredVariable65.Rationality; //IsContext = False IsNew = False
											OperandVar72 = prop71;
										} else { UnityEngine.Debug.Log("StoredVariable65 != null = false " ); }
									} else { UnityEngine.Debug.Log("prop70 != null = false " ); }
								} else { UnityEngine.Debug.Log("subContext45 != null = false " ); }
								
								ut = ( (( (OperandVar67)) * ( (0.33f)))) + ( (( (OperandVar69)) * ( (0.33f)))) + ( (( (OperandVar72)) * ( (0.33f))));
							} else { UnityEngine.Debug.Log("( ( (OperandVar62))) && ( (!(OperandVar64))) = false " ); }
						} else { UnityEngine.Debug.Log("subContext45 != null = false " ); }
					}
				} else { UnityEngine.Debug.Log("FuncCtx44 != null = false " ); }
			}
			return ut;
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			UnityEngine.Debug.Log(root);
			
			
			
			
			{
				World FuncCtx73 = External.GetWorld();; //IsContext = True IsNew = False
				
				if(FuncCtx73 != null)
				{
					
					{
						Blackboards.events_data subContext74 = FuncCtx73.GetComponent<Blackboards.events_data>(); //IsContext = True IsNew = False
						
						if(subContext74 != null)
						{
							
							subContext74.WizardBurned =  (true);
						} else { UnityEngine.Debug.Log("subContext74 != null = false " ); }
					}
				} else { UnityEngine.Debug.Log("FuncCtx73 != null = false " ); }
			}
			UnityEngine.GameObject wizard_event = new UnityEngine.GameObject("wizard_event"); //IsContext = False IsNew = False
			
			{
				UnityEngine.GameObject wizard_event75 = wizard_event; //IsContext = True IsNew = False
				Event AddContext76 = wizard_event.AddComponent<Event>(); //IsContext = True IsNew = True
				
				{
					
					if(AddContext76 != null)
					{
						Actor OperandVar78 = default(Actor); //IsContext = False IsNew = False
						Actor StoredVariable77 = root.GetComponent<Actor>(); //IsContext = False IsNew = False
						if(StoredVariable77 != null)
						{
							OperandVar78 = StoredVariable77;
						} else { UnityEngine.Debug.Log("StoredVariable77 != null = false " ); }
						AddContext76.Involved =  (OperandVar78);
						Blackboards.burn_event act = wizard_event75.AddComponent<Blackboards.burn_event>();; //IsContext = False IsNew = True
						
						{
							
							if(act != null)
							{
								UnityEngine.GameObject OperandVar82 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
								World prop79 = External.GetWorld(); //IsContext = False IsNew = False
								if(prop79 != null)
								{
									Blackboards.events_data StoredVariable80 = prop79.GetComponent<Blackboards.events_data>(); //IsContext = False IsNew = False
									if(StoredVariable80 != null)
									{
										UnityEngine.GameObject prop81 = StoredVariable80.Wizard; //IsContext = False IsNew = False
										if(prop81 != null)
										{
											OperandVar82 = prop81;
										} else { UnityEngine.Debug.Log("prop81 != null = false " ); }
									} else { UnityEngine.Debug.Log("StoredVariable80 != null = false " ); }
								} else { UnityEngine.Debug.Log("prop79 != null = false " ); }
								act.Target =  (OperandVar82);
							} else { UnityEngine.Debug.Log("act != null = false " ); }
						}
						Blackboards.burn_event OperandVar83 = default(Blackboards.burn_event); //IsContext = False IsNew = False
						OperandVar83 = act;
						AddContext76.Action =  (OperandVar83);
					} else { UnityEngine.Debug.Log("AddContext76 != null = false " ); }
				}
			}
			UnityEngine.Object.FindObjectOfType<Generators>().Generate(wizard_event);
		}
        }
    }
    
    public class burn_wizard_desc : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			UnityEngine.Debug.Log(root);
			
			
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar86 = default(System.Boolean); //IsContext = False IsNew = False
			Event StoredVariable84 = root.GetComponent<Event>(); //IsContext = False IsNew = False
			if(StoredVariable84 != null)
			{
				Blackboards.burn_event StoredVariable85 = StoredVariable84.GetComponent<Blackboards.burn_event>(); //IsContext = False IsNew = False
				if(StoredVariable85 != null)
				{
					applicable = true;
					OperandVar86 = applicable;
				} else { UnityEngine.Debug.Log("StoredVariable85 != null = false " ); }
			} else { UnityEngine.Debug.Log("StoredVariable84 != null = false " ); }
			return (System.Boolean) (OperandVar86);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			UnityEngine.Debug.Log(root);
			
			
			System.Single ut = 0; //IsContext = False IsNew = False
			
			System.Boolean OperandVar89 = default(System.Boolean); //IsContext = False IsNew = False
			EventsController prop87 = External.GetEventsController(); //IsContext = False IsNew = False
			if(prop87 != null)
			{
				System.Boolean prop88 = prop87.HasDesc; //IsContext = False IsNew = False
				OperandVar89 = prop88;
			} else { UnityEngine.Debug.Log("prop87 != null = false " ); }
			if(!(OperandVar89))
			{
				
				ut =  (1f);
			} else { UnityEngine.Debug.Log("!(OperandVar89) = false " ); }
			return ut;
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			UnityEngine.Debug.Log(root);
			
			
			
			
			{
				EventsController FuncCtx90 = External.GetEventsController();; //IsContext = True IsNew = False
				
				if(FuncCtx90 != null)
				{
					
					FuncCtx90.HasDesc =  (true);
					
					System.String OperandVar94 = default(System.String); //IsContext = False IsNew = False
					Event StoredVariable91 = root.GetComponent<Event>(); //IsContext = False IsNew = False
					if(StoredVariable91 != null)
					{
						Actor prop92 = StoredVariable91.Involved; //IsContext = False IsNew = False
						if(prop92 != null)
						{
							System.String prop93 = prop92.Name; //IsContext = False IsNew = False
							if(prop93 != null)
							{
								OperandVar94 = prop93;
							} else { UnityEngine.Debug.Log("prop93 != null = false " ); }
						} else { UnityEngine.Debug.Log("prop92 != null = false " ); }
					} else { UnityEngine.Debug.Log("StoredVariable91 != null = false " ); }
					
					
					
					System.String OperandVar99 = default(System.String); //IsContext = False IsNew = False
					Blackboards.burn_event StoredVariable95 = root.GetComponent<Blackboards.burn_event>(); //IsContext = False IsNew = False
					if(StoredVariable95 != null)
					{
						UnityEngine.GameObject prop96 = StoredVariable95.Target; //IsContext = False IsNew = False
						if(prop96 != null)
						{
							Actor StoredVariable97 = prop96.GetComponent<Actor>(); //IsContext = False IsNew = False
							if(StoredVariable97 != null)
							{
								System.String prop98 = StoredVariable97.Name; //IsContext = False IsNew = False
								if(prop98 != null)
								{
									OperandVar99 = prop98;
								} else { UnityEngine.Debug.Log("prop98 != null = false " ); }
							} else { UnityEngine.Debug.Log("StoredVariable97 != null = false " ); }
						} else { UnityEngine.Debug.Log("prop96 != null = false " ); }
					} else { UnityEngine.Debug.Log("StoredVariable95 != null = false " ); }
					FuncCtx90.EventDescription(( ( (OperandVar94))) + ( ( (" gonna burn the wizard. This wizard is known by name "))) + ( ( (OperandVar99))));
				} else { UnityEngine.Debug.Log("FuncCtx90 != null = false " ); }
			}
		}
        }
    }
    
    public class burn_wizard_reaction_watch : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			UnityEngine.Debug.Log(root);
			
			
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar107 = default(System.Boolean); //IsContext = False IsNew = False
			Event StoredVariable100 = root.GetComponent<Event>(); //IsContext = False IsNew = False
			if(StoredVariable100 != null)
			{
				Blackboards.burn_event StoredVariable101 = StoredVariable100.GetComponent<Blackboards.burn_event>(); //IsContext = False IsNew = False
				if(StoredVariable101 != null)
				{
					
					
					System.Boolean OperandVar103 = default(System.Boolean); //IsContext = False IsNew = False
					System.Boolean prop102 = StoredVariable101.ChurchReaction; //IsContext = False IsNew = False
					OperandVar103 = prop102;
					
					
					
					
					System.Single OperandVar106 = default(System.Single); //IsContext = False IsNew = False
					Player prop104 = External.GetPlayer(); //IsContext = False IsNew = False
					if(prop104 != null)
					{
						System.Single prop105 = prop104.Church; //IsContext = False IsNew = False
						OperandVar106 = prop105;
					} else { UnityEngine.Debug.Log("prop104 != null = false " ); }
					
					
					if(( (( ( (OperandVar103))) == ( ( (false))))) && ( (( ( (OperandVar106))) > ( ( (45f))))))
					{
						applicable = true;
						OperandVar107 = applicable;
					} else { UnityEngine.Debug.Log("( (( ( (OperandVar103))) == ( ( (false))))) && ( (( ( (OperandVar106))) > ( ( (45f))))) = false " ); }
				} else { UnityEngine.Debug.Log("StoredVariable101 != null = false " ); }
			} else { UnityEngine.Debug.Log("StoredVariable100 != null = false " ); }
			return (System.Boolean) (OperandVar107);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			UnityEngine.Debug.Log(root);
			
			
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			UnityEngine.Debug.Log(root);
			
			
			
			
			{
				Blackboards.burn_event subContext108 = root.GetComponent<Blackboards.burn_event>(); //IsContext = True IsNew = False
				
				if(subContext108 != null)
				{
					
					subContext108.ChurchReaction =  (true);
				} else { UnityEngine.Debug.Log("subContext108 != null = false " ); }
			}
			
			{
				EventsController FuncCtx109 = External.GetEventsController();; //IsContext = True IsNew = False
				
				if(FuncCtx109 != null)
				{
					
					VoidDelegate Lambda110 = () => 
					{
						UnityEngine.GameObject OperandVar111 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
						OperandVar111 = root;
						External.Log( (OperandVar111));
						UnityEngine.GameObject OperandVar114 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
						Blackboards.burn_event StoredVariable112 = root.GetComponent<Blackboards.burn_event>(); //IsContext = False IsNew = False
						if(StoredVariable112 != null)
						{
							UnityEngine.GameObject prop113 = StoredVariable112.Target; //IsContext = False IsNew = False
							if(prop113 != null)
							{
								OperandVar114 = prop113;
							} else { UnityEngine.Debug.Log("prop113 != null = false " ); }
						} else { UnityEngine.Debug.Log("StoredVariable112 != null = false " ); }
						External.Destroy( (OperandVar114));
						Event OperandVar116 = default(Event); //IsContext = False IsNew = False
						Event StoredVariable115 = FuncCtx109.GetComponent<Event>(); //IsContext = False IsNew = False
						if(StoredVariable115 != null)
						{
							OperandVar116 = StoredVariable115;
						} else { UnityEngine.Debug.Log("StoredVariable115 != null = false " ); }
						External.Destroy( (OperandVar116));
						
						{
							Player FuncCtx117 = External.GetPlayer();; //IsContext = True IsNew = False
							
							if(FuncCtx117 != null)
							{
								
								System.Single OperandVar119 = default(System.Single); //IsContext = False IsNew = False
								System.Single prop118 = FuncCtx117.Church; //IsContext = False IsNew = False
								OperandVar119 = prop118;
								
								
								FuncCtx117.Church = ( ( (OperandVar119))) + ( ( (10f)));
							} else { UnityEngine.Debug.Log("FuncCtx117 != null = false " ); }
						}
						
						{
							World FuncCtx120 = External.GetWorld();; //IsContext = True IsNew = False
							
							if(FuncCtx120 != null)
							{
								
								{
									Blackboards.events_data subContext121 = FuncCtx120.GetComponent<Blackboards.events_data>(); //IsContext = True IsNew = False
									
									if(subContext121 != null)
									{
										UnityEngine.GameObject OperandVar123 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
										UnityEngine.GameObject prop122 = External.NoOne(); //IsContext = False IsNew = False
										if(prop122 != null)
										{
											OperandVar123 = prop122;
										} else { UnityEngine.Debug.Log("prop122 != null = false " ); }
										subContext121.Wizard =  (OperandVar123);
										
										subContext121.WizardBurned =  (false);
									} else { UnityEngine.Debug.Log("subContext121 != null = false " ); }
								}
							} else { UnityEngine.Debug.Log("FuncCtx120 != null = false " ); }
						}
					};
					FuncCtx109.Reaction( ("Let him burn"),Lambda110);
				} else { UnityEngine.Debug.Log("FuncCtx109 != null = false " ); }
			}
		}
        }
    }
    
    public class burn_wizard_reaction_kill : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			UnityEngine.Debug.Log(root);
			
			
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar131 = default(System.Boolean); //IsContext = False IsNew = False
			Event StoredVariable124 = root.GetComponent<Event>(); //IsContext = False IsNew = False
			if(StoredVariable124 != null)
			{
				Blackboards.burn_event StoredVariable125 = StoredVariable124.GetComponent<Blackboards.burn_event>(); //IsContext = False IsNew = False
				if(StoredVariable125 != null)
				{
					
					
					System.Boolean OperandVar127 = default(System.Boolean); //IsContext = False IsNew = False
					System.Boolean prop126 = StoredVariable125.KillReaction; //IsContext = False IsNew = False
					OperandVar127 = prop126;
					
					
					
					
					System.Single OperandVar130 = default(System.Single); //IsContext = False IsNew = False
					Player prop128 = External.GetPlayer(); //IsContext = False IsNew = False
					if(prop128 != null)
					{
						System.Single prop129 = prop128.Church; //IsContext = False IsNew = False
						OperandVar130 = prop129;
					} else { UnityEngine.Debug.Log("prop128 != null = false " ); }
					
					
					if(( (( ( (OperandVar127))) == ( ( (false))))) && ( (( ( (OperandVar130))) <=( ( (75f))))))
					{
						applicable = true;
						OperandVar131 = applicable;
					} else { UnityEngine.Debug.Log("( (( ( (OperandVar127))) == ( ( (false))))) && ( (( ( (OperandVar130))) <=( ( (75f))))) = false " ); }
				} else { UnityEngine.Debug.Log("StoredVariable125 != null = false " ); }
			} else { UnityEngine.Debug.Log("StoredVariable124 != null = false " ); }
			return (System.Boolean) (OperandVar131);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			UnityEngine.Debug.Log(root);
			
			
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			UnityEngine.Debug.Log(root);
			
			
			
			
			{
				Blackboards.burn_event subContext132 = root.GetComponent<Blackboards.burn_event>(); //IsContext = True IsNew = False
				
				if(subContext132 != null)
				{
					
					subContext132.KillReaction =  (true);
				} else { UnityEngine.Debug.Log("subContext132 != null = false " ); }
			}
			
			{
				EventsController FuncCtx133 = External.GetEventsController();; //IsContext = True IsNew = False
				
				if(FuncCtx133 != null)
				{
					
					VoidDelegate Lambda134 = () => 
					{
						UnityEngine.GameObject OperandVar135 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
						OperandVar135 = root;
						External.Log( (OperandVar135));
						Actor OperandVar138 = default(Actor); //IsContext = False IsNew = False
						Event StoredVariable136 = root.GetComponent<Event>(); //IsContext = False IsNew = False
						if(StoredVariable136 != null)
						{
							Actor prop137 = StoredVariable136.Involved; //IsContext = False IsNew = False
							if(prop137 != null)
							{
								OperandVar138 = prop137;
							} else { UnityEngine.Debug.Log("prop137 != null = false " ); }
						} else { UnityEngine.Debug.Log("StoredVariable136 != null = false " ); }
						External.Destroy( (OperandVar138));
						Event OperandVar139 = default(Event); //IsContext = False IsNew = False
						if(StoredVariable136 != null)
						{
							OperandVar139 = StoredVariable136;
						} else { UnityEngine.Debug.Log("StoredVariable136 != null = false " ); }
						External.Destroy( (OperandVar139));
						
						{
							Player FuncCtx140 = External.GetPlayer();; //IsContext = True IsNew = False
							
							if(FuncCtx140 != null)
							{
								
								System.Single OperandVar142 = default(System.Single); //IsContext = False IsNew = False
								System.Single prop141 = FuncCtx140.Church; //IsContext = False IsNew = False
								OperandVar142 = prop141;
								
								
								FuncCtx140.Church = ( ( (OperandVar142))) - ( ( (10f)));
							} else { UnityEngine.Debug.Log("FuncCtx140 != null = false " ); }
						}
						
						{
							World FuncCtx143 = External.GetWorld();; //IsContext = True IsNew = False
							
							if(FuncCtx143 != null)
							{
								
								{
									Blackboards.events_data subContext144 = FuncCtx143.GetComponent<Blackboards.events_data>(); //IsContext = True IsNew = False
									
									if(subContext144 != null)
									{
										UnityEngine.GameObject OperandVar146 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
										UnityEngine.GameObject prop145 = External.NoOne(); //IsContext = False IsNew = False
										if(prop145 != null)
										{
											OperandVar146 = prop145;
										} else { UnityEngine.Debug.Log("prop145 != null = false " ); }
										subContext144.Wizard =  (OperandVar146);
										
										subContext144.WizardBurned =  (false);
									} else { UnityEngine.Debug.Log("subContext144 != null = false " ); }
								}
							} else { UnityEngine.Debug.Log("FuncCtx143 != null = false " ); }
						}
					};
					FuncCtx133.Reaction( ("I can't tolerate such atrocity, kill him and free the guy"),Lambda134);
				} else { UnityEngine.Debug.Log("FuncCtx133 != null = false " ); }
			}
		}
        }
    }
}
